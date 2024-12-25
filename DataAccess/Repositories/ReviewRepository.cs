using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Review (отзыв).
    /// Реализует интерфейс IReviewRepository.
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public ReviewRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}