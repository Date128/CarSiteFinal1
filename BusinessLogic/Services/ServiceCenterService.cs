using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью ServiceCenter (сервисный центр).
    /// Реализует интерфейс IServiceCenterService.
    public class ServiceCenterService : IServiceCenterService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public ServiceCenterService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех сервисных центров.
        /// <returns>Список сервисных центров.</returns>
        public async Task<List<ServiceCenter>> GetAll()
        {
            return await _repositoryWrapper.ServiceCenter.FindAll();
        }

        /// Получает сервисный центр по его идентификатору.
        /// <param name="id">Идентификатор сервисного центра.</param>
        /// <returns>Сервисный центр.</returns>
        public async Task<ServiceCenter> GetById(int id)
        {
            var serviceCenter = await _repositoryWrapper.ServiceCenter
                .FindByCondition(x => x.CenterId == id);
            return serviceCenter.First();
        }

        /// Создаёт новый сервисный центр.
        /// <param name="model">Модель сервисного центра.</param>
        public async Task Create(ServiceCenter model)
        {
            await _repositoryWrapper.ServiceCenter.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о сервисном центре.
        /// <param name="model">Модель сервисного центра с обновлёнными данными.</param>
        public async Task Update(ServiceCenter model)
        {
            _repositoryWrapper.ServiceCenter.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет сервисный центр по его идентификатору.
        /// <param name="id">Идентификатор сервисного центра.</param>
        public async Task Delete(int id)
        {
            var serviceCenter = await _repositoryWrapper.ServiceCenter
                .FindByCondition(x => x.CenterId == id);

            _repositoryWrapper.ServiceCenter.Delete(serviceCenter.First());
            _repositoryWrapper.Save();
        }
    }
}