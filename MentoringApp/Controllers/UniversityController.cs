using MentoringApp.Data.Models;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MentoringApp.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UniversityController(IUnitOfWork unitOfWork)
        {
          _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<University> universityList = _unitOfWork.University.GetAll().ToList();
            return View(universityList);
        }
    }
}
