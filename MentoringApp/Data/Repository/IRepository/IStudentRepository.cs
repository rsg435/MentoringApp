using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        //Student
        public void AddMentor(Student obj);
        public void GetMentors(string city, string AreaOfStudy);
        public Student GetMentor(int studentId);

        //Mentor
        public void AddStudent(Student obj);
        public List<Student> GetStudents(int mentorId);
    }
}
