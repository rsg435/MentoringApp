using MentoringApp.Data.Models;
using MentoringApp.Models;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        private bool _currentUserIsMentor;

		public ConnectionController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
			_unitOfWork = unitOfWork;
			_httpContextAccessor = httpContextAccessor;
			_currentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            GetUserRole();

		}

        public void GetUserRole()
        {
            var user = _unitOfWork.Student.GetStudent(_currentUserId);
            _currentUserIsMentor = user.Role == UserRole.Mentor;
        }
        public IActionResult Index()
        {
            var model = new StudentConnectionRequestModel();
            IEnumerable<ConnectionRequest> dbRequests = _unitOfWork.Connection.GetPendingRequests(_currentUserId);
            foreach(var request in dbRequests)
            {
                var req = new StudentRequest
                {
                    StudentId = request.StudentId,
                    MentorId = request.MentorId,
                    RequestId = request.Id,
                    StudentName = request.Student.Name,
                    MentorName = request.Mentor.Name,
                    RequestStatus = request.Status.ToString(),
                };
                model.Requests.Add(req);
            }
            model.CurrentUserIsMentor = _currentUserIsMentor;
            return View(model);
		}

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

        public IActionResult UpdateRequest(StudentRequest request, Status status)
        {
            _unitOfWork.Connection.UpdateRequestStatus(request.RequestId, status);
            if(status == Status.Accepted)
            {
                _unitOfWork.Student.AssignMentor(request.StudentId, request.MentorId);
            }
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}
