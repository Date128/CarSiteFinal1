using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с сервисными центрами.
    public interface IServiceCenterService
    {
        /// Получает список всех сервисных центров.
        /// <returns>Список сервисных центров.</returns>
        Task<List<ServiceCenter>> GetAll();

        /// Получает сервисный центр по его идентификатору.
        /// <param name="id">Идентификатор сервисного центра.</param>
        /// <returns>Сервисный центр.</returns>
        Task<ServiceCenter> GetById(int id);

        /// Создает новый сервисный центр.
        /// <param name="model">Модель сервисного центра для создания.</param>
        Task Create(ServiceCenter model);

        /// Обновляет существующий сервисный центр.
        /// <param name="model">Модель сервисного центра для обновления.</param>
        Task Update(ServiceCenter model);

        /// Удаляет сервисный центр по его идентификатору.
        /// <param name="id">Идентификатор сервисного центра.</param>
        Task Delete(int id);
    }
}