using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью News (новости).
    /// Реализует интерфейс INewsRepository.
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public NewsRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}