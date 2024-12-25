using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с постами.
    public interface IPostService
    {
        /// Получает список всех постов.
        /// <returns>Список постов.</returns>
        Task<List<Post>> GetAll();

        /// Получает пост по его идентификатору.
        /// <param name="id">Идентификатор поста.</param>
        /// <returns>Пост.</returns>
        Task<Post> GetById(int id);

        /// Создает новый пост.
        /// <param name="model">Модель поста для создания.</param>
        Task Create(Post model);

        /// Обновляет существующий пост.
        /// <param name="model">Модель поста для обновления.</param>
        Task Update(Post model);

        /// Удаляет пост по его идентификатору.
        /// <param name="id">Идентификатор поста.</param>
        Task Delete(int id);
    }
}