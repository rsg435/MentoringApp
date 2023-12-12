using MentoringApp.Data.DTOs;
using MentoringApp.Data.Models;
using MentoringApp.Data.Enums;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using MentoringApp.Models;

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
            var viewModel = new StudentListViewModel();

            IEnumerable<StudentDto> mentorList = _unitOfWork.Student.GetMentors(currentUser.University.Id, currentUser.AreaOfStudy).ToList();
            if(mentorList.Count() < 1 || mentorList == null)
            {
                IEnumerable<StudentDto> allMentors = _unitOfWork.Student.GetMentors(currentUser.University.Id, null).ToList();
                viewModel.Students = allMentors;
                viewModel.Message = "We couldn't find any mentors with the same area of study as you, so we've shown all the mentors at your university.";
            }
            else
            {
                viewModel.Students = mentorList;
            }
            return View(viewModel);
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
                var mentor = _unitOfWork.Student.GetMentorForStudent(_currentUserId);
                if (mentor != null)
                {
                    users.Add(mentor);
                }     
            }
            else if (User.IsInRole(Role.Mentor.ToString()))
            {
                users.AddRange(_unitOfWork.Student.GetMentees(_currentUserId));
            }
            if(users.Count() < 1 || users == null)
            {
                var noResultsModel = new NoResultsViewModel();
                noResultsModel.Message = "You don't have any contacts at the moment.";
                return View("NoResults", noResultsModel);
            }
            return View(users);
		}
    }
}
