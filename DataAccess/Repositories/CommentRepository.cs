using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Comment (комментарий).
    /// Реализует интерфейс ICommentRepository.
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public CommentRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}