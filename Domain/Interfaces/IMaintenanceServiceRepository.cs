using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с репозиторием услуг обслуживания (MaintenanceService).
    /// Наследует базовый интерфейс IRepositoryBase<MaintenanceService>.
    public interface IMaintenanceServiceRepository : IRepositoryBase<MaintenanceService>
    {


    }
}