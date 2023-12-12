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
                         && (string.IsNullOrEmpty(AreaOfStudy) || student.AreaOfStudy == AreaOfStudy)
                         && student.UniversityId == universityId
                         select new StudentDto
                         {
                             Id = student.Id,
                             Name = student.Name,
                             CourseName = student.CourseName,
                             AreaOfStudy = student.AreaOfStudy,
                             Role = role.Name,
                             University = student.University,
                             ProfilePictureUrl = student.ProfilePictureUrl,
                             IntroductionMessage = student.IntroductionMessage
                         }).ToList();
            return mentors;               
        }

        public Student GetMentorForStudent(string studentId)
        {
            var student = _context.Students
                .Where(s => s.Id == studentId)
				.Include(s => s.Mentor)
                .FirstOrDefault();
            return student.Mentor;
        }

        public List<Student> GetMentees(string mentorId)
        {
            var mentor = _context.Students
                .FirstOrDefault(s => s.Id == mentorId);
            return mentor.Mentees;
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
