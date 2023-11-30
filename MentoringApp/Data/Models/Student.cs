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
        [ForeignKey("UniversityId")]
        [Required]
        public University University { get; set; }
        public string? MentorId { get; set; }
        [ForeignKey("MentorId")]
        public Mentor? Mentor { get; set; }
        public List<ConnectionRequest> ConnectionRequests { get; set; }

    }
}
