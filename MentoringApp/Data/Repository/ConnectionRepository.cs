using MentoringApp.Data.Models;
using MentoringApp.Repository;
using MentoringApp.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MentoringApp.Data.Repository
{
    public class ConnectionRepository : Repository<ConnectionRequest>, IConnectionRepository
    {
        private ApplicationDbContext _context;
        public ConnectionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
		public void UpdateRequestStatus(int requestId, Status status)
		{
            var request = _context.ConnectionRequests.FirstOrDefault(r => r.Id == requestId);
            if (request != null)
            {
                request.Status = status;
            }
        }

		public List<ConnectionRequest> GetPendingRequests(string userId)
        {
            var user = _context.Students.FirstOrDefault(s => s.Id == userId);
            var requestList = new List<ConnectionRequest>();
            if(user != null)
            {
				switch (user.Role)
				{
					case UserRole.Student:
						requestList = user.SentConnectionRequests.Where(c => c.Status == Status.Pending).ToList();
						break;

					case UserRole.Mentor:
						requestList = user.ReceivedConnectionRequests.Where(c => c.Status == Status.Pending).ToList();
						break;
				}
			}
            return requestList;
        }

		public void SendRequest(string requesterId, string receiverId)
        {
            var request = new ConnectionRequest
            {
                StudentId = requesterId,
                MentorId = receiverId,
                Status = Status.Pending
            };
            _context.ConnectionRequests.Add(request);
        }
    }
}
