using MentoringApp.Data.Models;

namespace MentoringApp.Data.DTOs
{
	public class NotificationDto
	{
		public Notification Notification { get; set; }
		public string Message { get; set; } = "";
		public string CreatedDateSt => this.Notification.CreatedDate.ToString("dd-MMM-yyyy HH:mm:ss");
		public string IsReadSt => this.Notification.IsRead ? "YES" : "NO";
		public string FromName { get; set; } = "";
		public string ToName { get; set; } = "";
	}
}
