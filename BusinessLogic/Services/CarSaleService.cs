using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью CarSale (продажа автомобиля).
    /// Реализует интерфейс ICarSaleService.
    public class CarSaleService : ICarSaleService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public CarSaleService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех продаж автомобилей.
        /// <returns>Список продаж автомобилей.</returns>
        public async Task<List<CarSale>> GetAll()
        {
            return await _repositoryWrapper.CarSale.FindAll();
        }

        /// Получает продажу автомобиля по её идентификатору.
        /// <param name="id">Идентификатор продажи автомобиля.</param>
        /// <returns>Продажа автомобиля.</returns>
        public async Task<CarSale> GetById(int id)
        {
            var carSale = await _repositoryWrapper.CarSale
                .FindByCondition(x => x.SaleId == id);
            return carSale.First();
        }

        /// Создаёт новую продажу автомобиля.
        /// <param name="model">Модель продажи автомобиля.</param>
        public async Task Create(CarSale model)
        {
            await _repositoryWrapper.CarSale.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о продаже автомобиля.
        /// <param name="model">Модель продажи автомобиля с обновлёнными данными.</param>
        public async Task Update(CarSale model)
        {
            _repositoryWrapper.CarSale.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет продажу автомобиля по её идентификатору.
        /// <param name="id">Идентификатор продажи автомобиля.</param>
        public async Task Delete(int id)
        {
            var carSale = await _repositoryWrapper.CarSale
                .FindByCondition(x => x.SaleId == id);

            _repositoryWrapper.CarSale.Delete(carSale.First());
            _repositoryWrapper.Save();
        }
    }
}