using MentoringApp.Data.Models;
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

		public ConnectionController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
			_unitOfWork = unitOfWork;
			_httpContextAccessor = httpContextAccessor;
			_currentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
		}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConnectionRequests()
        {
            IEnumerable<ConnectionRequest> requests = _unitOfWork.Connection.GetPendingRequests(_currentUserId);
            
            return View(requests);
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

            return RedirectToAction(nameof(ConnectionRequests));
        }
    }
}
