using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью PostTag (тег поста).
    /// Реализует интерфейс IPostTagRepository.
    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public PostTagRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}