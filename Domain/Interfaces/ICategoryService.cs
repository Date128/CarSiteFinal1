using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с категориями.
    public interface ICategoryService
    {
        /// Получает список всех категорий.
        /// <returns>Список категорий.</returns>
        Task<List<Category>> GetAll();

        /// Получает категорию по ее идентификатору.
        /// <param name="id">Идентификатор категории.</param>
        /// <returns>Категория.</returns>
        Task<Category> GetById(int id);

        /// Создает новую категорию.
        /// <param name="model">Модель категории для создания.</param>
        Task Create(Category model);

        /// Обновляет существующую категорию.
        /// <param name="model">Модель категории для обновления.</param>
        Task Update(Category model);

        /// Удаляет категорию по ее идентификатору.
        /// <param name="id">Идентификатор категории.</param>
        Task Delete(int id);
    }
}
