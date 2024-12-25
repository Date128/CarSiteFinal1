using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с тегами постов.
    public interface IPostTagService
    {
        /// Получает список всех связей тегов с постами.
        /// <returns>Список связей тегов с постами.</returns>
        Task<List<PostTag>> GetAll();

        /// Получает связь тега с постом по ее идентификатору.
        /// <param name="id">Идентификатор связи тега с постом.</param>
        /// <returns>Связь тега с постом.</returns>
        Task<PostTag> GetById(int id);

        /// Создает новую связь тега с постом.
        /// <param name="model">Модель связи тега с постом для создания.</param>
        Task Create(PostTag model);

        /// Обновляет существующую связь тега с постом.
        /// <param name="model">Модель связи тега с постом для обновления.</param>
        Task Update(PostTag model);

        /// Удаляет связь тега с постом по ее идентификатору.
        /// <param name="id">Идентификатор связи тега с постом.</param>
        Task Delete(int id);
    }
}