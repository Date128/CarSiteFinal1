using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с продажами автомобилей.
    public interface ICarSaleService
    {
        /// Получает список всех продаж автомобилей.
        /// <returns>Список продаж автомобилей.</returns>
        Task<List<CarSale>> GetAll();

        /// Получает продажу автомобиля по ее идентификатору.
        /// <param name="id">Идентификатор продажи автомобиля.</param>
        /// <returns>Продажа автомобиля.</returns>
        Task<CarSale> GetById(int id);

        /// Создает новую продажу автомобиля.
        /// <param name="model">Модель продажи автомобиля для создания.</param>
        Task Create(CarSale model);

        /// Обновляет существующую продажу автомобиля.
        /// <param name="model">Модель продажи автомобиля для обновления.</param>
        Task Update(CarSale model);

        /// Удаляет продажу автомобиля по ее идентификатору.
        /// <param name="id">Идентификатор продажи автомобиля.</param>
        Task Delete(int id);
    }
}