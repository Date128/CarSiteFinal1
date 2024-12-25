using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью TechnicalMaintenance (техническое обслуживание).
    /// Реализует интерфейс ITechnicalMaintenanceRepository.
    public class TechnicalMaintenanceRepository : RepositoryBase<TechnicalMaintenance>, ITechnicalMaintenanceRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public TechnicalMaintenanceRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}