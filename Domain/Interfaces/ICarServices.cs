using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с автомобилями.
    public interface ICarServices
    {
        /// Получает список всех автомобилей.
        /// <returns>Список автомобилей.</returns>
        Task<List<Car>> GetAll();

        /// Получает автомобиль по его идентификатору.
        /// <param name="id">Идентификатор автомобиля.</param>
        /// <returns>Автомобиль.</returns>
        Task<Car> GetById(int id);

        /// Создает новый автомобиль.
        /// <param name="model">Модель автомобиля для создания.</param>
        Task Create(Car model);

        /// Обновляет существующий автомобиль.
        /// <param name="model">Модель автомобиля для обновления.</param>
        Task Update(Car model);

        /// Удаляет автомобиль по его идентификатору.
        /// <param name="id">Идентификатор автомобиля.</param>
        Task Delete(int id);
    }
}