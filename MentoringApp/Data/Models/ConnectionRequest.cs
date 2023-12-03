using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentoringApp.Data.Models
{
    public class ConnectionRequest
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public Status Status { get; set; }
		public string StudentId { get; set; }
        public Student Student { get; set; }
        public string MentorId { get; set; }
        public Student Mentor { get; set; }
    }
    public enum Status
    {
        Pending,
        Accepted,
        Rejected
    }
}
