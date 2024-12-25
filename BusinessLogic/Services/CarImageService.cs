using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью CarImage (изображение автомобиля).
    /// Реализует интерфейс ICarImageService.
    public class CarImageService : ICarImageService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public CarImageService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех изображений автомобилей.
        /// <returns>Список изображений автомобилей.</returns>
        public async Task<List<CarImage>> GetAll()
        {
            return await _repositoryWrapper.CarImage.FindAll();
        }

        /// Получает изображение автомобиля по его идентификатору.
        /// <param name="id">Идентификатор изображения автомобиля.</param>
        /// <returns>Изображение автомобиля.</returns>
        public async Task<CarImage> GetById(int id)
        {
            var carImage = await _repositoryWrapper.CarImage
                .FindByCondition(x => x.ImageId == id);
            return carImage.First();
        }

        /// Создаёт новое изображение автомобиля.
        /// <param name="model">Модель изображения автомобиля.</param>
        public async Task Create(CarImage model)
        {
            await _repositoryWrapper.CarImage.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию об изображении автомобиля.
        /// <param name="model">Модель изображения автомобиля с обновлёнными данными.</param>
        public async Task Update(CarImage model)
        {
            _repositoryWrapper.CarImage.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет изображение автомобиля по его идентификатору.
        /// <param name="id">Идентификатор изображения автомобиля.</param>
        public async Task Delete(int id)
        {
            var carImage = await _repositoryWrapper.CarImage
                .FindByCondition(x => x.ImageId == id);

            _repositoryWrapper.CarImage.Delete(carImage.First());
            _repositoryWrapper.Save();
        }
    }
}