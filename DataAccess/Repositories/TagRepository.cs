using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Tag (тег).
    /// Реализует интерфейс ITagRepository.
    internal class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public TagRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}