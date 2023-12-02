using MentoringApp.Data;
using MentoringApp.Data.Models;
using MentoringApp.Repository.IRepository;

namespace MentoringApp.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void AssignMentor(Student obj, int mentorId)
        {
            throw new NotImplementedException();
        }

        public Student GetMentor(int studentId)
        {
            throw new NotImplementedException();
        }

        public void GetMentors(University university, string AreaOfStudy)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents(int mentorId)
        {
            throw new NotImplementedException();
        }
    }
}
