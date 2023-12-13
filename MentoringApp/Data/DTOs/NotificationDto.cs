using MentoringApp.Data.Models;

namespace MentoringApp.Data.DTOs
{
	public class NotificationDto
	{
        public string NotiHeader { get; set; } = "";
        public string NotiBody { get; set; } = "";
        public bool IsRead { get; set; } = false;
        public string Url { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Message { get; set; } = "";
		public string CreatedDateSt => this.CreatedDate.ToString("dd-MMM-yyyy HH:mm:ss");
		public string IsReadSt => this.IsRead ? "YES" : "NO";
		public string FromName { get; set; } = "";
		public string ToName { get; set; } = "";
	}
}
