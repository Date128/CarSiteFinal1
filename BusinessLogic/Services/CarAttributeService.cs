using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью CarAttribute (атрибуты автомобиля).
    /// Реализует интерфейс ICarAttributeService.
    public class CarAttributeService : ICarAttributeService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public CarAttributeService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех атрибутов автомобилей.
        /// <returns>Список атрибутов автомобилей.</returns>
        public async Task<List<CarAttribute>> GetAll()
        {
            return await _repositoryWrapper.CarAttribute.FindAll();
        }

        /// Получает атрибут автомобиля по его идентификатору и идентификатору атрибута.
        /// <param name="carId">Идентификатор автомобиля.</param>
        /// <param name="attributeId">Идентификатор атрибута.</param>
        /// <returns>Атрибут автомобиля.</returns>
        public async Task<CarAttribute> GetById(int carId, int attributeId)
        {
            var carAttribute = await _repositoryWrapper.CarAttribute
                .FindByCondition(x => x.CarId == carId && x.AttributeId == attributeId);
            return carAttribute.First();
        }

        /// Создаёт новый атрибут автомобиля.
        /// <param name="model">Модель атрибута автомобиля.</param>
        public async Task Create(CarAttribute model)
        {
            await _repositoryWrapper.CarAttribute.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию об атрибуте автомобиля.
        /// <param name="model">Модель атрибута автомобиля с обновлёнными данными.</param>
        public async Task Update(CarAttribute model)
        {
            _repositoryWrapper.CarAttribute.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет атрибут автомобиля по его идентификатору и идентификатору атрибута.
        /// <param name="carId">Идентификатор автомобиля.</param>
        /// <param name="attributeId">Идентификатор атрибута.</param>
        public async Task Delete(int carId, int attributeId)
        {
            var carAttribute = await _repositoryWrapper.CarAttribute
                .FindByCondition(x => x.CarId == carId && x.AttributeId == attributeId);

            _repositoryWrapper.CarAttribute.Delete(carAttribute.First());
            _repositoryWrapper.Save();
        }
    }
}