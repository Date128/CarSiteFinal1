using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    /// Абстрактный базовый класс для реализации репозиториев.
    /// Предоставляет базовые методы для работы с сущностями в базе данных.
    /// <typeparam name="T">Тип сущности, с которой работает репозиторий.</typeparam>
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        /// Контекст базы данных, используемый для работы с данными.
        protected CarsiteContext RepositoryContext { get; set; }

        /// Конструктор базового репозитория.
        /// <param name="repositoryContext">Контекст базы данных.</param>
        public RepositoryBase(CarsiteContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        /// Получает список всех сущностей типа <typeparamref name="T"/>.
        /// <returns>Список сущностей.</returns>
        public async Task<List<T>> FindAll() =>
            await RepositoryContext.Set<T>().AsNoTracking().ToListAsync();

        /// Получает список сущностей типа <typeparamref name="T"/>, удовлетворяющих заданному условию.
        /// <param name="expression">Условие для фильтрации сущностей.</param>
        /// <returns>Список сущностей, удовлетворяющих условию.</returns>
        public async Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression) =>
            await RepositoryContext.Set<T>().Where(expression).AsNoTracking().ToListAsync();

        /// Создаёт новую сущность типа <typeparamref name="T"/>.
        /// <param name="entity">Сущность для создания.</param>
        public async Task Create(T entity) =>
            await RepositoryContext.Set<T>().AddAsync(entity);

        /// Обновляет существующую сущность типа <typeparamref name="T"/>.
        /// <param name="entity">Сущность с обновлёнными данными.</param>
        public async Task Update(T entity) =>
            RepositoryContext.Set<T>().Update(entity);

        /// Удаляет сущность типа <typeparamref name="T"/>.
        /// <param name="entity">Сущность для удаления.</param>
        public async Task Delete(T entity) =>
            RepositoryContext.Set<T>().Remove(entity);
    }
}