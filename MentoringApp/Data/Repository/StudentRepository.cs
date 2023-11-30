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
        public void Update(Student obj)
        {
            //_context.Students.Update(obj);
        }
    }
}
