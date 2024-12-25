using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью ServiceCenter (сервисный центр).
    /// Реализует интерфейс IServiceCenterRepository.
    public class ServiceCenterRepository : RepositoryBase<ServiceCenter>, IServiceCenterRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public ServiceCenterRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}