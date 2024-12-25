using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Car (автомобиль).
    /// Реализует интерфейс ICarServices.
    public class CarService : ICarServices
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public CarService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех автомобилей.
        /// <returns>Список автомобилей.</returns>
        public async Task<List<Car>> GetAll()
        {
            return await _repositoryWrapper.Car.FindAll();
        }

        /// Получает автомобиль по его идентификатору.
        /// <param name="id">Идентификатор автомобиля.</param>
        /// <returns>Автомобиль.</returns>
        public async Task<Car> GetById(int id)
        {
            var car = await _repositoryWrapper.Car
                .FindByCondition(x => x.CarId == id);
            return car.First();
        }

        /// Создаёт новый автомобиль.
        /// <param name="model">Модель автомобиля.</param>
        public async Task Create(Car model)
        {
            await _repositoryWrapper.Car.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию об автомобиле.
        /// <param name="model">Модель автомобиля с обновлёнными данными.</param>
        public async Task Update(Car model)
        {
            _repositoryWrapper.Car.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет автомобиль по его идентификатору.
        /// <param name="id">Идентификатор автомобиля.</param>
        public async Task Delete(int id)
        {
            var car = await _repositoryWrapper.CarSale
                .FindByCondition(x => x.CarId == id);

            _repositoryWrapper.CarSale.Delete(car.First());
            _repositoryWrapper.Save();
        }
    }
}