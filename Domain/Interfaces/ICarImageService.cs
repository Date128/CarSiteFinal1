using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с изображениями автомобилей (CarImage).
    /// Определяет методы для получения, создания, обновления и удаления изображений.
    public interface ICarImageService
    {
        /// Получает список всех изображений автомобилей.
        /// <returns>Список изображений автомобилей.</returns>
        Task<List<CarImage>> GetAll();

        /// Получает изображение автомобиля по его идентификатору.
        /// <param name="id">Идентификатор изображения.</param>
        /// <returns>Изображение автомобиля.</returns>
        Task<CarImage> GetById(int id);

        /// Создаёт новое изображение автомобиля.
        /// <param name="model">Модель изображения автомобиля.</param>
        Task Create(CarImage model);

        /// Обновляет информацию об изображении автомобиля.
        /// <param name="model">Модель изображения автомобиля с обновлёнными данными.</param>
        Task Update(CarImage model);

        /// Удаляет изображение автомобиля по его идентификатору.
        /// <param name="id">Идентификатор изображения.</param>
        Task Delete(int id);
    }
}