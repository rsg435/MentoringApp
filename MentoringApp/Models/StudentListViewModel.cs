namespace MentoringApp.Models
{
	public class StudentListViewModel
	{
		public IEnumerable<MentoringApp.Data.DTOs.StudentDto> Students { get; set; }
		public string Message { get; set; }
	}
}
