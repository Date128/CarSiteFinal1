using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс репозитория для работы с рекомендациями экспертов.
    /// Наследует базовые методы работы с сущностями из IRepositoryBase<ExpertRecommendation>.
    public interface IExpertRecommendationRepository : IRepositoryBase<ExpertRecommendation>
    {
       
    }
}