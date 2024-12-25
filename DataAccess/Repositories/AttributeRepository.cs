using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Attribute (атрибут).
    /// Реализует интерфейс IAttributeRepository.
    public class AttributeRepository : RepositoryBase<Domain.Models.Attribute>, IAttributeRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public AttributeRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}