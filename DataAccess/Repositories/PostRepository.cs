using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Post (пост).
    /// Реализует интерфейс IPostRepository.
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public PostRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}