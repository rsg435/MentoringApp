using System.ComponentModel.DataAnnotations;

namespace MentoringApp.Data.Models
{
    public class University
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
