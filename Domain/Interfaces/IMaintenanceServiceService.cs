using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с услугами технического обслуживания.
    public interface IMaintenanceServiceService
    {
        /// Получает список всех услуг технического обслуживания.
        /// <returns>Список услуг технического обслуживания.</returns>
        Task<List<MaintenanceService>> GetAll();

        /// Получает услугу технического обслуживания по ее идентификатору.
        /// <param name="id">Идентификатор услуги технического обслуживания.</param>
        /// <returns>Услуга технического обслуживания.</returns>
        Task<MaintenanceService> GetById(int id);

        /// Создает новую услугу технического обслуживания.
        /// <param name="model">Модель услуги технического обслуживания для создания.</param>
        Task Create(MaintenanceService model);

        /// Обновляет существующую услугу технического обслуживания.
        /// <param name="model">Модель услуги технического обслуживания для обновления.</param>
        Task Update(MaintenanceService model);

        /// Удаляет услугу технического обслуживания по ее идентификатору.
        /// <param name="id">Идентификатор услуги технического обслуживания.</param>
        Task Delete(int id);
    }
}