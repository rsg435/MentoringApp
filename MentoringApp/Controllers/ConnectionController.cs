using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MentoringApp.Controllers
{
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
    }
}
