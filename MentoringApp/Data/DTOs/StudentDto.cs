using MentoringApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace MentoringApp.Data.DTOs
{
	public class StudentDto
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string CourseName { get; set; }
		public string AreaOfStudy { get; set; }
		public string Role { get; set; }
		public University University { get; set; }
		public Student Mentor { get; set; }
		public List<Student> Mentees { get; set; } = null;
		public List<ConnectionRequest> SentConnectionRequests { get; set; } = new List<ConnectionRequest>();
		public List<ConnectionRequest> ReceivedConnectionRequests { get; set; } = new List<ConnectionRequest>();
		public string ProfilePictureUrl { get; set; }
		public string IntroductionMessage { get; set; }
	}
}
