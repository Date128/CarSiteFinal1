using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с арендой автомобилей.
    public interface ICarRentalService
    {
        /// Получает список всех аренд автомобилей.
        /// <returns>Список аренд автомобилей.</returns>
        Task<List<CarRental>> GetAll();

        /// Получает аренду автомобиля по ее идентификатору.
        /// <param name="id">Идентификатор аренды автомобиля.</param>
        /// <returns>Аренда автомобиля.</returns>
        Task<CarRental> GetById(int id);

        /// Создает новую аренду автомобиля.
        /// <param name="model">Модель аренды автомобиля для создания.</param>
        Task Create(CarRental model);

        /// Обновляет существующую аренду автомобиля.
        /// <param name="model">Модель аренды автомобиля для обновления.</param>
        Task Update(CarRental model);

        /// Удаляет аренду автомобиля по ее идентификатору.
        /// <param name="id">Идентификатор аренды автомобиля.</param>
        Task Delete(int id);
    }
}