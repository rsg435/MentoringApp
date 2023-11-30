using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        //Student
        public void AddMentor(Mentor obj);
        public void GetMentors(string city, string AreaOfStudy);
        public Mentor GetMentor(int studentId);

        //Mentor
        public void AddStudent(Student obj);
        public List<Student> GetStudents(int mentorId);
    }
}
