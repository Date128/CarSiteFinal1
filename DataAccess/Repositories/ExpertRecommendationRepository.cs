using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью ExpertRecommendation (рекомендации экспертов).
    /// Реализует интерфейс IExpertRecommendationRepository.
    public class ExpertRecommendationRepository : RepositoryBase<ExpertRecommendation>, IExpertRecommendationRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public ExpertRecommendationRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}