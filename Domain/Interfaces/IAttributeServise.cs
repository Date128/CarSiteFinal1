using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyAttribute = Domain.Models.Attribute;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с атрибутами (Attribute).
    /// Определяет методы для получения, создания, обновления и удаления атрибутов.
    public interface IAttributeServise
    {
        /// Получает список всех атрибутов.
        /// <returns>Список атрибутов.</returns>
        Task<List<MyAttribute>> GetAll();

        /// Получает атрибут по его идентификатору.
        /// <param name="id">Идентификатор атрибута.</param>
        /// <returns>Атрибут.</returns>
        Task<MyAttribute> GetById(int id);

        /// Создаёт новый атрибут.
        /// <param name="model">Модель атрибута.</param>
        Task Create(MyAttribute model);

        /// Обновляет информацию об атрибуте.
        /// <param name="model">Модель атрибута с обновлёнными данными.</param>
        Task Update(MyAttribute model);

        /// Удаляет атрибут по его идентификатору.
        /// <param name="id">Идентификатор атрибута.</param>
        Task Delete(int id);
    }
}
