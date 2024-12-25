using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с профилями пользователей.
    public interface IUserProfileService
    {
        /// Получает список всех профилей пользователей.
        /// <returns>Список профилей пользователей.</returns>
        Task<List<UserProfile>> GetAll();

        /// Получает профиль пользователя по его идентификатору.
        /// <param name="id">Идентификатор профиля пользователя.</param>
        /// <returns>Профиль пользователя.</returns>
        Task<UserProfile> GetById(int id);

        /// Создает новый профиль пользователя.
        /// <param name="model">Модель профиля пользователя для создания.</param>
        Task Create(UserProfile model);

        /// Обновляет существующий профиль пользователя.
        /// <param name="model">Модель профиля пользователя для обновления.</param>
        Task Update(UserProfile model);

        /// Удаляет профиль пользователя по его идентификатору.
        /// <param name="id">Идентификатор профиля пользователя.</param>
        Task Delete(int id);
    }
}