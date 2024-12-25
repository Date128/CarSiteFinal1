using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью MaintenanceService (услуга обслуживания).
    /// Реализует интерфейс IMaintenanceServiceService.
    public class MaintenanceServiceService : IMaintenanceServiceService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public MaintenanceServiceService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех услуг обслуживания.
        /// <returns>Список услуг обслуживания.</returns>
        public async Task<List<MaintenanceService>> GetAll()
        {
            return await _repositoryWrapper.MaintenanceService.FindAll();
        }

        /// Получает услугу обслуживания по её идентификатору.
        /// <param name="id">Идентификатор услуги обслуживания.</param>
        /// <returns>Услуга обслуживания.</returns>
        public async Task<MaintenanceService> GetById(int id)
        {
            var maintenanceService = await _repositoryWrapper.MaintenanceService
                .FindByCondition(x => x.ServiceId == id);
            return maintenanceService.First();
        }

        /// Создаёт новую услугу обслуживания.
        /// <param name="model">Модель услуги обслуживания.</param>
        public async Task Create(MaintenanceService model)
        {
            await _repositoryWrapper.MaintenanceService.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию об услуге обслуживания.
        /// <param name="model">Модель услуги обслуживания с обновлёнными данными.</param>
        public async Task Update(MaintenanceService model)
        {
            _repositoryWrapper.MaintenanceService.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет услугу обслуживания по её идентификатору.
        /// <param name="id">Идентификатор услуги обслуживания.</param>
        public async Task Delete(int id)
        {
            var maintenanceService = await _repositoryWrapper.MaintenanceService
                .FindByCondition(x => x.ServiceId == id);

            _repositoryWrapper.MaintenanceService.Delete(maintenanceService.First());
            _repositoryWrapper.Save();
        }
    }
}