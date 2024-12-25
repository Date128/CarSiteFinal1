using Domain.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с репозиторием отзывов (Review).
    /// Наследует базовый интерфейс IRepositoryBase<Review>.
    public interface IReviewRepository : IRepositoryBase<Review>
    {
    }
}