using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью CarRental (аренда автомобиля).
    /// Реализует интерфейс ICarRentalService.
    public class CarRentalService : ICarRentalService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public CarRentalService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех аренд автомобилей.
        /// <returns>Список аренд автомобилей.</returns>
        public async Task<List<CarRental>> GetAll()
        {
            return await _repositoryWrapper.CarRental.FindAll();
        }

        /// Получает аренду автомобиля по её идентификатору.
        /// <param name="id">Идентификатор аренды автомобиля.</param>
        /// <returns>Аренда автомобиля.</returns>
        public async Task<CarRental> GetById(int id)
        {
            var carRental = await _repositoryWrapper.CarRental
                .FindByCondition(x => x.RentalId == id);
            return carRental.First();
        }

        /// Создаёт новую аренду автомобиля.
        /// <param name="model">Модель аренды автомобиля.</param>
        public async Task Create(CarRental model)
        {
            await _repositoryWrapper.CarRental.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию об аренде автомобиля.
        /// <param name="model">Модель аренды автомобиля с обновлёнными данными.</param>
        public async Task Update(CarRental model)
        {
            _repositoryWrapper.CarRental.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет аренду автомобиля по её идентификатору.
        /// <param name="id">Идентификатор аренды автомобиля.</param>
        public async Task Delete(int id)
        {
            var carRental = await _repositoryWrapper.CarRental
                .FindByCondition(x => x.RentalId == id);

            _repositoryWrapper.CarRental.Delete(carRental.First());
            _repositoryWrapper.Save();
        }
    }
}