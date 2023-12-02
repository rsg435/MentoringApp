using MentoringApp.Data;
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

        public List<Student> GetMentors(int universityId, string AreaOfStudy)
        {
            var mentors = _context.Students
                .Where(s => s.UniversityId == universityId && s.AreaOfStudy == AreaOfStudy && s.Role == UserRole.Mentor)
                .Include(s => s.University)
                .ToList();
            return mentors;
        }

        public Student? GetMentorForStudent(string studentId)
        {
            var student = _context.Students
                .FirstOrDefault(s => s.Id == studentId);
            if(student != null)
            {
                return student.Mentor ?? null;
            }
            return null;
        }

        public List<Student>? GetMentees(string mentorId)
        {
            var mentor = _context.Students
                .FirstOrDefault(s => s.Id == mentorId);
            if(mentor != null)
            {
                return mentor.Mentees ?? null;
            }
            return null;
        }
    }
}
