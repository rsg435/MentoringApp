using MentoringApp.Data.Models;

namespace MentoringApp.Models
{
	public class StudentConnectionRequestModel
	{
		public List<StudentRequest> Requests { get; set; }
		public bool CurrentUserIsMentor { get; set; }
	}

	public class StudentRequest
	{
		public string StudentId { get; set; }
		public string MentorId { get; set; }
		public int RequestId { get; set; }
		public string StudentName { get; set; }
		public string MentorName { get; set; }
		public string RequestStatus { get; set; }
	}
}
