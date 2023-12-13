using MentoringApp.Data.Models;
using MentoringApp.Repository.IRepository;
using MentoringApp.Repository;
using MentoringApp.Data.Repository.IRepository;
using MentoringApp.Data.DTOs;

namespace MentoringApp.Data.Repository
{
	public class NotificationRepository : Repository<Notification>, INotificationRepository
	{
		private ApplicationDbContext _context;
		public NotificationRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public List<NotificationDto> GetNotifications(string toUserId, bool getOnlyUnread)
		{
			var notifications = new List<NotificationDto>();
			if (!getOnlyUnread)
			{
				 notifications = _context.Notifications
				.Where(n => n.ToUserId == toUserId)
				.Select(n => new NotificationDto
				{
					CreatedDate = n.CreatedDate,
					Url = n.Url,
					IsRead = n.IsRead,
					NotiHeader = n.NotiHeader,
					NotiBody = n.NotiBody,
					Message = n.NotiBody,
					FromName = n.FromUser.Name,
					ToName = n.ToUser.Name
				})
				.ToList();
			}
			else
			{
				notifications = _context.Notifications
			   .Where(n => n.ToUserId == toUserId && !n.IsRead)
			   .Select(n => new NotificationDto
			   {
                   CreatedDate = n.CreatedDate,
                   Url = n.Url,
                   IsRead = n.IsRead,
                   NotiHeader = n.NotiHeader,
                   NotiBody = n.NotiBody,
                   Message = n.NotiBody,
                   FromName = n.FromUser.Name,
                   ToName = n.ToUser.Name
               })
			   .ToList();
			}
			 return notifications;
		}
	}
}

