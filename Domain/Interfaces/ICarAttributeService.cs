using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с атрибутами автомобиля.
    public interface ICarAttributeService
    {
        /// Получает список всех атрибутов автомобиля.
        /// <returns>Список атрибутов автомобиля.</returns>
        Task<List<CarAttribute>> GetAll();

        /// Получает атрибут автомобиля по идентификаторам автомобиля и атрибута.
        /// <param name="carId">Идентификатор автомобиля.</param>
        /// <param name="attributeId">Идентификатор атрибута.</param>
        /// <returns>Атрибут автомобиля.</returns>
        Task<CarAttribute> GetById(int carId, int attributeId);

        /// Создает новый атрибут автомобиля.
        /// <param name="model">Модель атрибута автомобиля для создания.</param>
        Task Create(CarAttribute model);

        /// Обновляет существующий атрибут автомобиля.
        /// <param name="model">Модель атрибута автомобиля для обновления.</param>
        Task Update(CarAttribute model);

        /// Удаляет атрибут автомобиля по идентификаторам автомобиля и атрибута.
        /// <param name="carId">Идентификатор автомобиля.</param>
        /// <param name="attributeId">Идентификатор атрибута.</param>
        Task Delete(int carId, int attributeId);
    }
}