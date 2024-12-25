using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с тегами (Tag).
    /// Определяет методы для получения, создания, обновления и удаления тегов.
    public interface ITagService
    {
        /// Получает список всех тегов.
        /// <returns>Список тегов.</returns>
        Task<List<Tag>> GetAll();

        /// Получает тег по его идентификатору.
        /// <param name="id">Идентификатор тега.</param>
        /// <returns>Тег.</returns>
        Task<Tag> GetById(int id);

        /// Создаёт новый тег.
        /// <param name="model">Модель тега.</param>
        Task Create(Tag model);

        /// Обновляет информацию о теге.
        /// <param name="model">Модель тега с обновлёнными данными.</param>
        Task Update(Tag model);

        /// Удаляет тег по его идентификатору.
        /// <param name="id">Идентификатор тега.</param>
        Task Delete(int id);
    }
}