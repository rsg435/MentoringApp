using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MentoringApp.Controllers
{
    public class ConnectionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConnectionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
