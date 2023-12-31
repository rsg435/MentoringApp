﻿using MentoringApp.Data.Enums;
using MentoringApp.Data.Models;
using MentoringApp.Models;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.Security.Claims;

namespace MentoringApp.Controllers
{
    [Authorize]
    public class ConnectionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
		private IHttpContextAccessor _httpContextAccessor;
		private readonly string _currentUserId;

		public ConnectionController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
			_unitOfWork = unitOfWork;
			_httpContextAccessor = httpContextAccessor;
			_currentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

		}

        public IActionResult Index()
        {
            IEnumerable<ConnectionRequest> dbRequests = _unitOfWork.Connection.GetPendingRequests(_currentUserId);
            if (dbRequests.Count() < 1 || dbRequests == null)
            {
                var noResultsModel = new NoResultsViewModel();
                noResultsModel.Message = "You don't have any pending requests at the moment.";
                return View("NoResults", noResultsModel);
            }
            return View(dbRequests);
		}

        [HttpPost]
        public IActionResult SendRequest(string receiverId)
        {
            if (_unitOfWork.Student.HasMentor(_currentUserId))
            {
                TempData["error"] = "The request was not sent because you already have a mentor.";
            }
            else if(_unitOfWork.Connection.RequestExists(_currentUserId, receiverId))
            {
                TempData["error"] = "You have already sent a request to this mentor.";
            }
            else
            {
				_unitOfWork.Connection.SendRequest(_currentUserId, receiverId);
				_unitOfWork.Save();

                var notificationMentor = new Notification
                {
                    ToUserId = receiverId,
                    FromUserId = _currentUserId,
                    CreatedDate = DateTime.Now,
                    NotiHeader = "New Connection Request",
                    NotiBody = "You have received a new connection request. Please check your pending requests for more details.",
                };
                _unitOfWork.Notification.Add(notificationMentor);
                _unitOfWork.Save();
      
				TempData["success"] = "Request sent!";
			}
            return RedirectToAction("Index", "Student", new { area = "" });
		}

		[HttpPost]
		public IActionResult AcceptRequest(int requestId)
        {
            var req = _unitOfWork.Connection.Get(x => x.Id == requestId);
            _unitOfWork.Connection.UpdateRequestStatus(requestId, Status.Accepted);
            _unitOfWork.Student.AssignMentor(req.StudentId, req.MentorId);
            _unitOfWork.Save();
            TempData["success"] = "Request accepted!";

            var notificationStudent = new Notification
            {
                ToUserId = req.StudentId,
                FromUserId = req.MentorId,
                CreatedDate = DateTime.Now,
                NotiHeader = "Connection Request Accepted",
                NotiBody = "Your connection request was accepted! Please check Contacts to get in touch with your mentor",
            };
            _unitOfWork.Notification.Add(notificationStudent);
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }

		[HttpPost]
		public IActionResult RejectRequest(int requestId)
		{
			var req = _unitOfWork.Connection.Get(x => x.Id == requestId);
			_unitOfWork.Connection.UpdateRequestStatus(requestId, Status.Rejected);
			_unitOfWork.Save();
            TempData["error"] = "Request rejected.";

            var notificationStudent = new Notification
            {
                ToUserId = req.StudentId,
                FromUserId = req.MentorId,
                CreatedDate = DateTime.Now,
                NotiHeader = "Connection Request Rejected",
                NotiBody = "Sadly, your connection request was not accepted. The mentor may be too busy right now. Please try a different mentor.",
            };
            _unitOfWork.Notification.Add(notificationStudent);
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
		}
	}
}
