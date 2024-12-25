using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с записями обслуживания (MaintenanceRecord).
    /// Определяет методы для получения, создания, обновления и удаления записей обслуживания.
    public interface IMaintenanceRecordService
    {
        /// Получает список всех записей обслуживания.
        /// <returns>Список записей обслуживания.</returns>
        Task<List<MaintenanceRecord>> GetAll();

        /// Получает запись обслуживания по её идентификатору.
        /// <param name="id">Идентификатор записи обслуживания.</param>
        /// <returns>Запись обслуживания.</returns>
        Task<MaintenanceRecord> GetById(int id);

        /// Создаёт новую запись обслуживания.
        /// <param name="model">Модель записи обслуживания.</param>
        Task Create(MaintenanceRecord model);

        /// Обновляет информацию о записи обслуживания.
        /// <param name="model">Модель записи обслуживания с обновлёнными данными.</param>
        Task Update(MaintenanceRecord model);

        /// Удаляет запись обслуживания по её идентификатору.
        /// <param name="id">Идентификатор записи обслуживания.</param>
        Task Delete(int id);
    }
}