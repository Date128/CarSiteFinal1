using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс репозитория для работы с автомобилями.
    /// Наследует базовые методы работы с сущностями из IRepositoryBase<Car>.
    public interface ICarRepository : IRepositoryBase<Car>
    {
        
    }
}