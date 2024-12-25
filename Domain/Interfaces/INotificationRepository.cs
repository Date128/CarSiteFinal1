using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс репозитория для работы с уведомлениями.
    /// Наследует базовые методы работы с сущностями из IRepositoryBase<Notification>.
    public interface INotificationRepository : IRepositoryBase<Notification>
    {
    
    }
}
