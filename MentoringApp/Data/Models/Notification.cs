using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MentoringApp.Data.Models
{
	public class Notification
	{
		[Key]
		public int Id { get; set; }
		public string FromUserId { get; set; } = "0";
		public string ToUserId { get; set; } = "0";
		public virtual Student FromUser { get; set; }
		public virtual Student ToUser { get; set; }
		public string NotiHeader { get; set; } = "";
		public string NotiBody { get; set; } = "";
		public bool IsRead { get; set; } = false;
		public string Url { get; set; } = "";
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		
	}
}
