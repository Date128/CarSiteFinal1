using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Notification (уведомление).
    /// Реализует интерфейс INotificationService.
    public class NotificationService : INotificationService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public NotificationService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех уведомлений.
        /// <returns>Список уведомлений.</returns>
        public async Task<List<Notification>> GetAll()
        {
            return await _repositoryWrapper.Notification.FindAll();
        }

        /// Получает уведомление по его идентификатору.
        /// <param name="id">Идентификатор уведомления.</param>
        /// <returns>Уведомление.</returns>
        public async Task<Notification> GetById(int id)
        {
            var notification = await _repositoryWrapper.Notification
                .FindByCondition(x => x.NotificationId == id);
            return notification.First();
        }

        /// Создаёт новое уведомление.
        /// <param name="model">Модель уведомления.</param>
        public async Task Create(Notification model)
        {
            await _repositoryWrapper.Notification.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию об уведомлении.
        /// <param name="model">Модель уведомления с обновлёнными данными.</param>
        public async Task Update(Notification model)
        {
            _repositoryWrapper.Notification.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет уведомление по его идентификатору.
        /// <param name="id">Идентификатор уведомления.</param>
        public async Task Delete(int id)
        {
            var notification = await _repositoryWrapper.Notification
                .FindByCondition(x => x.NotificationId == id);

            _repositoryWrapper.Notification.Delete(notification.First());
            _repositoryWrapper.Save();
        }
    }
}