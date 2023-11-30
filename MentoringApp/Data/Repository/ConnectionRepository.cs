using MentoringApp.Data.Models;
using MentoringApp.Repository;
using MentoringApp.Repository.IRepository;

namespace MentoringApp.Data.Repository
{
    public class ConnectionRepository : Repository<ConnectionRequest>, IConnectionRepository
    {
        private ApplicationDbContext _context;
        public ConnectionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void AcceptRequest(string requesterId, string receiverId)
        {
            throw new NotImplementedException();
        }

        public void GetConnectionStatus(string requesterId, string receiverId)
        {
            throw new NotImplementedException();
        }

        public void GetPendingRequests(string userId)
        {
            throw new NotImplementedException();
        }

        public void SendRequest(string requesterId, string receiverId)
        {
            throw new NotImplementedException();
        }
    }
}
