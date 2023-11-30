using MentoringApp.Data.Models;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MentoringApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
          _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> studentList = _unitOfWork.Student.GetAll().ToList();
            return View(studentList);
        }
    }
}
