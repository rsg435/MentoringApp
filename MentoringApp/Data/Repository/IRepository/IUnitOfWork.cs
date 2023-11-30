namespace MentoringApp.Repository.IRepository
{
    public interface IUnitOfWork
    { 
        IStudentRepository Student { get; }
        IUniversityRepository University { get; }
        void Save();
    }
}
