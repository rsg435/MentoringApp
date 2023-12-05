using MentoringApp.Data.DTOs;
using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        public void AssignMentor(string studentId, string mentorId);
        public List<StudentDto> GetMentors(int universityId, string AreaOfStudy);
        public Student GetStudent(string studentId);
        public bool HasMentor(string studentId);
        public Student GetMentorForStudent(string studentId);
        public List<Student> GetMentees(string mentorId);
    }
}
