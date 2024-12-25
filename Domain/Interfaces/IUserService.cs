using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с пользователями.
    public interface IUserService
    {
        /// Получает список всех пользователей.
        /// <returns>Список пользователей.</returns>
        Task<List<User>> GetAll();

        /// Получает пользователя по его идентификатору.
        /// <param name="id">Идентификатор пользователя.</param>
        /// <returns>Пользователь.</returns>
        Task<User> GetById(int id);

        /// Создает нового пользователя.
        /// <param name="model">Модель пользователя для создания.</param>
        Task Create(User model);

        /// Обновляет существующего пользователя.
        /// <param name="model">Модель пользователя для обновления.</param>
        Task Update(User model);

        /// Удаляет пользователя по его идентификатору.
        /// <param name="id">Идентификатор пользователя.</param>
        Task Delete(int id);
    }
}