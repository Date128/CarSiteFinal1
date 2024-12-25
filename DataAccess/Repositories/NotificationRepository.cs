using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Notification (уведомление).
    /// Реализует интерфейс INotificationRepository.
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public NotificationRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}