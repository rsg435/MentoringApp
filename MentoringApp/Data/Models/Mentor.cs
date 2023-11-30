namespace MentoringApp.Data.Models
{
    public class Mentor : Student
    {
        public List<Student> Mentees { get; set; }
    }
}
