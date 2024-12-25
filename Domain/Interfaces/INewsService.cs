using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с новостями.
    public interface INewsService
    {
        /// Получает список всех новостей.
        /// <returns>Список новостей.</returns>
        Task<List<News>> GetAll();

        /// Получает новость по ее идентификатору.
        /// <param name="id">Идентификатор новости.</param>
        /// <returns>Новость.</returns>
        Task<News> GetById(int id);

        /// Создает новую новость.
        /// <param name="model">Модель новости для создания.</param>
        Task Create(News model);

        /// Обновляет существующую новость.
        /// <param name="model">Модель новости для обновления.</param>
        Task Update(News model);

        /// Удаляет новость по ее идентификатору.
        /// <param name="id">Идентификатор новости.</param>
        Task Delete(int id);
    }
}