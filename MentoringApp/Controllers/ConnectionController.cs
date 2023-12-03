using MentoringApp.Data.Enums;
using MentoringApp.Data.Models;
using MentoringApp.Models;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            return View(dbRequests);
		}

        [HttpPost]
        public IActionResult SendRequest(string receiverId)
        {
            if (_unitOfWork.Student.HasMentor(_currentUserId))
            {
                TempData["error"] = "The request was not sent because you already have a mentor.";
            }
            _unitOfWork.Connection.SendRequest(_currentUserId, receiverId);
            _unitOfWork.Save();

            TempData["success"] = "Request sent!";

            return RedirectToAction("Index", "Student", new { area = "" });
        }

		[HttpPost]
		public IActionResult AcceptRequest(int requestId)
        {
            var req = _unitOfWork.Connection.Get(x => x.Id == requestId);
            _unitOfWork.Connection.UpdateRequestStatus(requestId, Status.Accepted);
            _unitOfWork.Student.AssignMentor(req.StudentId, req.MentorId);
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }

		public IActionResult RejectRequest(int requestId)
		{
			var req = _unitOfWork.Connection.Get(x => x.Id == requestId);
			_unitOfWork.Connection.UpdateRequestStatus(requestId, Status.Rejected);
			_unitOfWork.Save();

			return RedirectToAction(nameof(Index));
		}
	}
}
