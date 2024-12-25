using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс репозитория для работы с продажами автомобилей.
    /// Наследует базовые методы работы с сущностями из IRepositoryBase<CarSale>.
    public interface ICarSaleRepository : IRepositoryBase<CarSale>
    {
      
    }
}