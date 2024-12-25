using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с записями о техническом обслуживании.
    public interface ITechnicalMaintenanceService
    {
        /// Получает список всех записей о техническом обслуживании.
        /// <returns>Список записей о техническом обслуживании.</returns>
        Task<List<TechnicalMaintenance>> GetAll();

        /// Получает запись о техническом обслуживании по ее идентификатору.
        /// <param name="id">Идентификатор записи о техническом обслуживании.</param>
        /// <returns>Запись о техническом обслуживании.</returns>
        Task<TechnicalMaintenance> GetById(int id);

        /// Создает новую запись о техническом обслуживании.
        /// <param name="model">Модель записи о техническом обслуживании для создания.</param>
        Task Create(TechnicalMaintenance model);

        /// Обновляет существующую запись о техническом обслуживании.
        /// <param name="model">Модель записи о техническом обслуживании для обновления.</param>
        Task Update(TechnicalMaintenance model);

        /// Удаляет запись о техническом обслуживании по ее идентификатору.
        /// <param name="id">Идентификатор записи о техническом обслуживании.</param>
        Task Delete(int id);
    }
}