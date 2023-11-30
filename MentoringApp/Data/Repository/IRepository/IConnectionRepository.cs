using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IConnectionRepository : IRepository<ConnectionRequest>
    {
        void SendRequest(string requesterId, string receiverId);
        void AcceptRequest(string requesterId, string receiverId);
        void GetPendingRequests(string userId);
        void GetConnectionStatus(string requesterId, string receiverId);
    }
}
