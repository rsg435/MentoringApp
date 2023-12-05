using MentoringApp.Data.DTOs;
using MentoringApp.Data.Models;
using MentoringApp.Data.Enums;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace MentoringApp.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly string _currentUserId;

        public StudentController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _currentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        public IActionResult Index() 
        {
            var currentUser = _unitOfWork.Student.GetStudent(_currentUserId);

            IEnumerable<StudentDto> mentorList = _unitOfWork.Student.GetMentors(currentUser.University.Id, currentUser.AreaOfStudy).ToList();
            return View(mentorList);
        }

        public IActionResult Details(string studentId)
        {
            var Student = _unitOfWork.Student.GetStudent(studentId);
            return View(Student);
        }

        public IActionResult Contacts()
        {
            var users = new List<Student>();
            if (User.IsInRole(Role.Student.ToString())){
                users.Add(_unitOfWork.Student.GetMentorForStudent(_currentUserId));
            }
            else if (User.IsInRole(Role.Mentor.ToString()))
            {
                users.AddRange(_unitOfWork.Student.GetMentees(_currentUserId));
            }
            return View(users);
		}
    }
}
