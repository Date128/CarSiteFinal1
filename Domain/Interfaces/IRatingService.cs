using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с рейтингами.
    public interface IRatingService
    {
        /// Получает список всех рейтингов.
        /// <returns>Список рейтингов.</returns>
        Task<List<Rating>> GetAll();

        /// Получает рейтинг по его идентификатору.
        /// <param name="id">Идентификатор рейтинга.</param>
        /// <returns>Рейтинг.</returns>
        Task<Rating> GetById(int id);

        /// Создает новый рейтинг.
        /// <param name="model">Модель рейтинга для создания.</param>
        Task Create(Rating model);

        /// Обновляет существующий рейтинг.
        /// <param name="model">Модель рейтинга для обновления.</param>
        Task Update(Rating model);

        /// Удаляет рейтинг по его идентификатору.
        /// <param name="id">Идентификатор рейтинга.</param>
        Task Delete(int id);
    }
}