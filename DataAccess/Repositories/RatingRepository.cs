using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Rating (рейтинг).
    /// Реализует интерфейс IRatingRepository.
    public class RatingRepository : RepositoryBase<Rating>, IRatingRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public RatingRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}