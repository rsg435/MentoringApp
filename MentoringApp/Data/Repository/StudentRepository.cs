using MentoringApp.Data;
using MentoringApp.Data.DTOs;
using MentoringApp.Data.Enums;
using MentoringApp.Data.Models;
using MentoringApp.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace MentoringApp.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void AssignMentor(string studentId, string mentorId)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
            if(student != null)
            {
                student.MentorId = mentorId;
            }
        }

        public Student GetStudent(string studentId)
        {
            var student = _context.Students
                .Where(s => s.Id == studentId)
                .Include(s => s.University)
                .ToList();
            return student.First();
        }

        public List<StudentDto> GetMentors(int universityId, string AreaOfStudy)
        { var mentors = (from student in _context.Students
                         join userRole in _context.UserRoles
                         on student.Id equals userRole.UserId
                         join role in _context.Roles
                         on userRole.RoleId equals role.Id
                         where role.Name == Role.Mentor.ToString()
                         && student.AreaOfStudy == AreaOfStudy
                         && student.UniversityId == universityId
                         select new StudentDto
                         {
                             Id = student.Id,
                             Name = student.Name,
                             CourseName = student.CourseName,
                             AreaOfStudy = student.AreaOfStudy,
                             Role = role.Name,
                             University = student.University,
                             ProfilePicture = student.ProfilePicture,
                             IntroductionMessage = student.IntroductionMessage
                         }).ToList();
            return mentors;               
        }

        public Student GetMentorForStudent(string studentId)
        {
            var student = _context.Students
                .FirstOrDefault(s => s.Id == studentId);
            if(student != null)
            {
                return student.Mentor ?? null;
            }
            return null;
        }

        public List<Student> GetMentees(string mentorId)
        {
            var mentor = _context.Students
                .FirstOrDefault(s => s.Id == mentorId);
            if(mentor != null)
            {
                return mentor.Mentees ?? null;
            }
            return null;
        }

		public bool HasMentor(string studentId)
		{
            var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
            if (!string.IsNullOrEmpty(student.MentorId))
            {
                return true;
            }
            return false;
		}
	}
}
