using MentoringApp.Data.Repository.IRepository;

namespace MentoringApp.Repository.IRepository
{
    public interface IUnitOfWork
    { 
        IStudentRepository Student { get; }
        IUniversityRepository University { get; }
        IConnectionRepository Connection { get; }
        INotificationRepository Notification { get; }
        void Save();
    }
}
