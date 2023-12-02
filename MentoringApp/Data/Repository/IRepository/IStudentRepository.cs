using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        //Student
        public void AssignMentor(Student obj, int mentorId);
        public void GetMentors(University university, string AreaOfStudy);
        public Student GetMentor(int studentId);

        //Mentor
        public List<Student> GetStudents(int mentorId);
    }
}
