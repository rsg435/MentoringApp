using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        //Student
        public void AssignMentor(string studentId, string mentorId);
        public List<Student>? GetMentors(int universityId, string AreaOfStudy);
        public Student GetStudent(string studentId);

        //Mentor
        public Student? GetMentorForStudent(string studentId);
        public List<Student>? GetMentees(string mentorId);
    }
}
