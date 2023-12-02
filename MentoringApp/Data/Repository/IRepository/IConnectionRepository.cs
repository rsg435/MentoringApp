using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IConnectionRepository : IRepository<ConnectionRequest>
    {
        void SendRequest(string requesterId, string receiverId);
        void UpdateRequestStatus(int requestId, Status status);
		public List<ConnectionRequest> GetPendingRequests(string userId);
    }
}
