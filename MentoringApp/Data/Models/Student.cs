using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MentoringApp.Data.Models
{
    public class Student : IdentityUser
    {
        [Required]
        [PersonalData]
        public string Name { get; set; }

        [Required]
        [DisplayName("Course Name")]
        public string CourseName { get; set; }

        [Required]
        [DisplayName("Area of Study")]
        public string AreaOfStudy { get; set; }

        [Required]
        public int UniversityId { get; set; }

        [Required]
        public University University { get; set; }

        [Required]
        public UserRole Role { get; set; }

        public string? MentorId { get; set; }

        [Required]
        public Student? Mentor { get; set; }
        public List<Student>? Mentees { get; set; }
        public List<ConnectionRequest> SentConnectionRequests { get; set; } = new List<ConnectionRequest>();
        public List<ConnectionRequest> ReceivedConnectionRequests { get; set; } = new List<ConnectionRequest>();

    }

    public enum UserRole
    {
        Student,
        Mentor
    }

    public class AreaOfStudy
    {
        public static readonly string CreativeArts = "Creative Arts";
        public static readonly string Languages = "Languages";
        public static readonly string ArtsAndHumanities = "Arts and Humanities";
        public static readonly string SocialSciences = "Social Sciences";
        public static readonly string Business = "Business";
        public static readonly string Science = "Science";
        public static readonly string Technology = "Technology";
        public static readonly string Maths = "Maths";
        public static readonly string Engineering = "Engineering";
        public static readonly string Health = "Health";
        public static readonly string Sport = "Sport";
        public static readonly string Other = "Other";
    }
}
