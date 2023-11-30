using MentoringApp.Data;
using MentoringApp.Repository.IRepository;

namespace MentoringApp.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        public IStudentRepository Student { get; private set; }
        public IUniversityRepository University { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Student = new StudentRepository(_context);
            University = new UniversityRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
