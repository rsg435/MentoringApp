using MentoringApp.Data.DTOs;
using MentoringApp.Data.Models;
using MentoringApp.Repository.IRepository;

namespace MentoringApp.Data.Repository.IRepository
{
	public interface INotificationRepository : IRepository<Notification>
	{
		List<NotificationDto> GetNotifications(string toUserId, bool getOnlyUnread);
	}
}