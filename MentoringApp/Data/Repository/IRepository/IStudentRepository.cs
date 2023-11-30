using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        void Update(Student obj);
    }
}
