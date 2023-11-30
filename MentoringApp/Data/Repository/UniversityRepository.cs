using MentoringApp.Data;
using MentoringApp.Data.Models;
using MentoringApp.Repository.IRepository;

namespace MentoringApp.Repository
{
    public class UniversityRepository : Repository<University>, IUniversityRepository
    {
        private ApplicationDbContext _context;
        public UniversityRepository(ApplicationDbContext context) : base(context)
        {
          _context = context;
        }
        public void Update(University obj)
        {
            //_context.Universities.Update(obj);
        }
    }
}
