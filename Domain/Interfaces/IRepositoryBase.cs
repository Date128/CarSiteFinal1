using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Базовый интерфейс для репозиториев, предоставляющий общие методы для работы с сущностями.
    /// <typeparam name="T">Тип сущности, с которой работает репозиторий.</typeparam>
    public interface IRepositoryBase<T>
    {
        /// Получает список всех сущностей типа <typeparamref name="T"/>.
        /// <returns>Список сущностей.</returns>
        Task<List<T>> FindAll();

        /// Получает список сущностей типа <typeparamref name="T"/>, удовлетворяющих заданному условию.
        /// <param name="expression">Условие для фильтрации сущностей.</param>
        /// <returns>Список сущностей, удовлетворяющих условию.</returns>
        Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression);

        /// Создаёт новую сущность типа <typeparamref name="T"/>.
        /// <param name="entity">Сущность для создания.</param>
        Task Create(T entity);

        /// Обновляет существующую сущность типа <typeparamref name="T"/>.
        /// <param name="entity">Сущность с обновлёнными данными.</param>
        Task Update(T entity);

        /// Удаляет сущность типа <typeparamref name="T"/>.
        /// <param name="entity">Сущность для удаления.</param>
        Task Delete(T entity);
    }
}