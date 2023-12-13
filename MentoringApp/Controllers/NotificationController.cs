using MentoringApp.Data.DTOs;
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
			return View();
		}

		public JsonResult GetNotifications(bool getOnlyUnread)
		{
			var notifications = new List<NotificationDto>();
			notifications = _unitOfWork.Notification.GetNotifications(_currentUserId, getOnlyUnread);
			return Json(notifications);
			
		}
	}
}
