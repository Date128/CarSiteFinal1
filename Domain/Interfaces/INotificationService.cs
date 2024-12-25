using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с уведомлениями (Notification).
    /// Определяет методы для получения, создания, обновления и удаления уведомлений.
    public interface INotificationService
    {
        /// Получает список всех уведомлений.
        /// <returns>Список уведомлений.</returns>
        Task<List<Notification>> GetAll();

        /// Получает уведомление по его идентификатору.
        /// <param name="id">Идентификатор уведомления.</param>
        /// <returns>Уведомление.</returns>
        Task<Notification> GetById(int id);

        /// Создаёт новое уведомление.
        /// <param name="model">Модель уведомления.</param>
        Task Create(Notification model);

        /// Обновляет информацию об уведомлении.
        /// <param name="model">Модель уведомления с обновлёнными данными.</param>
        Task Update(Notification model);

        /// Удаляет уведомление по его идентификатору.
        /// <param name="id">Идентификатор уведомления.</param>
        Task Delete(int id);
    }
}