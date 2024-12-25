using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью MaintenanceRecord (запись обслуживания).
    /// Реализует интерфейс IMaintenanceRecordRepository.
    public class MaintenanceRecordRepository : RepositoryBase<MaintenanceRecord>, IMaintenanceRecordRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public MaintenanceRecordRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}