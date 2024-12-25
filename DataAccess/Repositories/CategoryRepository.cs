using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Category (категория).
    /// Реализует интерфейс ICategoryRepository.
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public CategoryRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}