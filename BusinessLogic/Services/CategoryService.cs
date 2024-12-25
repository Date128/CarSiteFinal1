using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Category (категория).
    /// Реализует интерфейс ICategoryService.
    public class CategoryService : ICategoryService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public CategoryService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех категорий.
        /// <returns>Список категорий.</returns>
        public async Task<List<Category>> GetAll()
        {
            return await _repositoryWrapper.Category.FindAll();
        }

        /// Получает категорию по её идентификатору.
        /// <param name="id">Идентификатор категории.</param>
        /// <returns>Категория.</returns>
        public async Task<Category> GetById(int id)
        {
            var category = await _repositoryWrapper.Category
                .FindByCondition(x => x.CategoryId == id);
            return category.First();
        }

        /// Создаёт новую категорию.
        /// <param name="model">Модель категории.</param>
        public async Task Create(Category model)
        {
            await _repositoryWrapper.Category.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о категории.
        /// <param name="model">Модель категории с обновлёнными данными.</param>
        public async Task Update(Category model)
        {
            _repositoryWrapper.Category.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет категорию по её идентификатору.
        /// <param name="id">Идентификатор категории.</param>
        public async Task Delete(int id)
        {
            var category = await _repositoryWrapper.Category
                .FindByCondition(x => x.CategoryId == id);

            _repositoryWrapper.Category.Delete(category.First());
            _repositoryWrapper.Save();
        }
    }
}