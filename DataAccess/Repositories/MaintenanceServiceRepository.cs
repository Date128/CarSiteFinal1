using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью MaintenanceService (услуги обслуживания).
    /// Реализует интерфейс IMaintenanceServiceRepository.
    public class MaintenanceServiceRepository : RepositoryBase<MaintenanceService>, IMaintenanceServiceRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public MaintenanceServiceRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}