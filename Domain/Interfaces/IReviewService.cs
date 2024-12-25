using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с отзывами.
    public interface IReviewService
    {
        /// Получает список всех отзывов.
        /// <returns>Список отзывов.</returns>
        Task<List<Review>> GetAll();

        /// Получает отзыв по его идентификатору.
        /// <param name="id">Идентификатор отзыва.</param>
        /// <returns>Отзыв.</returns>
        Task<Review> GetById(int id);

        /// Создает новый отзыв.
        /// <param name="model">Модель отзыва для создания.</param>
        Task Create(Review model);

        /// Обновляет существующий отзыв.
        /// <param name="model">Модель отзыва для обновления.</param>
        Task Update(Review model);

        /// Удаляет отзыв по его идентификатору.
        /// <param name="id">Идентификатор отзыва.</param>
        Task Delete(int id);
    }
}