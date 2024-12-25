using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с комментариями.
    public interface ICommentService
    {
        /// Получает список всех комментариев.
        /// <returns>Список комментариев.</returns>
        Task<List<Comment>> GetAll();

        /// Получает комментарий по его идентификатору.
        /// <param name="id">Идентификатор комментария.</param>
        /// <returns>Комментарий.</returns>
        Task<Comment> GetById(int id);

        /// Создает новый комментарий.
        /// <param name="model">Модель комментария для создания.</param>
        Task Create(Comment model);

        /// Обновляет существующий комментарий.
        /// <param name="model">Модель комментария для обновления.</param>
        Task Update(Comment model);

        /// Удаляет комментарий по его идентификатору.
        /// <param name="id">Идентификатор комментария.</param>
        Task Delete(int id);
    }
}