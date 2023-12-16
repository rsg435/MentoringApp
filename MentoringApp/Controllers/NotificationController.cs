using MentoringApp.Data.DTOs;
using MentoringApp.Models;
using MentoringApp.Repository;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MentoringApp.Controllers
{
	[Authorize]
	public class NotificationController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		private IHttpContextAccessor _httpContextAccessor;
		private readonly string _currentUserId;

		public NotificationController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
			_unitOfWork = unitOfWork;
			_httpContextAccessor = httpContextAccessor;
			_currentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
		}
        public IActionResult Index()
		{
            var notifications = _unitOfWork.Notification.GetNotifications(_currentUserId, false);
            if (notifications.Count() < 1 || notifications == null)
            {
                var noResultsModel = new NoResultsViewModel();
                noResultsModel.Message = "You don't have any notifications at the moment.";
                return View("NoResults", noResultsModel);
            }
            return View(notifications);
		}

		public JsonResult GetNotifications()
		{
			var notifications = _unitOfWork.Notification.GetNotifications(_currentUserId, false);
			var json = Json(notifications);
			return json;
		}
	}
}
