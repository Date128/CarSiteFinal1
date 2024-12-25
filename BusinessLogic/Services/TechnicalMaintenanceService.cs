using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью TechnicalMaintenance (техническое обслуживание).
    /// Реализует интерфейс ITechnicalMaintenanceService.
    public class TechnicalMaintenanceService : ITechnicalMaintenanceService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public TechnicalMaintenanceService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех записей технического обслуживания.
        /// <returns>Список записей технического обслуживания.</returns>
        public async Task<List<TechnicalMaintenance>> GetAll()
        {
            return await _repositoryWrapper.TechnicalMaintenance.FindAll();
        }

        /// Получает запись технического обслуживания по её идентификатору.
        /// <param name="id">Идентификатор записи технического обслуживания.</param>
        /// <returns>Запись технического обслуживания.</returns>
        public async Task<TechnicalMaintenance> GetById(int id)
        {
            var technicalMaintenance = await _repositoryWrapper.TechnicalMaintenance
                .FindByCondition(x => x.MaintenanceId == id);
            return technicalMaintenance.First();
        }

        /// Создаёт новую запись технического обслуживания.
        /// <param name="model">Модель записи технического обслуживания.</param>
        public async Task Create(TechnicalMaintenance model)
        {
            await _repositoryWrapper.TechnicalMaintenance.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о записи технического обслуживания.
        /// <param name="model">Модель записи технического обслуживания с обновлёнными данными.</param>
        public async Task Update(TechnicalMaintenance model)
        {
            _repositoryWrapper.TechnicalMaintenance.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет запись технического обслуживания по её идентификатору.
        /// <param name="id">Идентификатор записи технического обслуживания.</param>
        public async Task Delete(int id)
        {
            var technicalMaintenance = await _repositoryWrapper.TechnicalMaintenance
                .FindByCondition(x => x.MaintenanceId == id);

            _repositoryWrapper.TechnicalMaintenance.Delete(technicalMaintenance.First());
            _repositoryWrapper.Save();
        }
    }
}