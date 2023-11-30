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

        public void AddMentor(Student obj)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(Student obj)
        {
            throw new NotImplementedException();
        }

        public Student GetMentor(int studentId)
        {
            throw new NotImplementedException();
        }

        public void GetMentors(string city, string AreaOfStudy)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents(int mentorId)
        {
            throw new NotImplementedException();
        }
    }
}
