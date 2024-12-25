using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью MaintenanceRecord (запись обслуживания).
    /// Реализует интерфейс IMaintenanceRecordService.
    public class MaintenanceRecordService : IMaintenanceRecordService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public MaintenanceRecordService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех записей обслуживания.
        /// <returns>Список записей обслуживания.</returns>
        public async Task<List<MaintenanceRecord>> GetAll()
        {
            return await _repositoryWrapper.MaintenanceRecord.FindAll();
        }

        /// Получает запись обслуживания по её идентификатору.
        /// <param name="id">Идентификатор записи обслуживания.</param>
        /// <returns>Запись обслуживания.</returns>
        public async Task<MaintenanceRecord> GetById(int id)
        {
            var maintenanceRecord = await _repositoryWrapper.MaintenanceRecord
                .FindByCondition(x => x.RecordId == id);
            return maintenanceRecord.First();
        }

        /// Создаёт новую запись обслуживания.
        /// <param name="model">Модель записи обслуживания.</param>
        public async Task Create(MaintenanceRecord model)
        {
            await _repositoryWrapper.MaintenanceRecord.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о записи обслуживания.
        /// <param name="model">Модель записи обслуживания с обновлёнными данными.</param>
        public async Task Update(MaintenanceRecord model)
        {
            _repositoryWrapper.MaintenanceRecord.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет запись обслуживания по её идентификатору.
        /// <param name="id">Идентификатор записи обслуживания.</param>
        public async Task Delete(int id)
        {
            var maintenanceRecord = await _repositoryWrapper.MaintenanceRecord
                .FindByCondition(x => x.RecordId == id);

            _repositoryWrapper.MaintenanceRecord.Delete(maintenanceRecord.First());
            _repositoryWrapper.Save();
        }
    }
}