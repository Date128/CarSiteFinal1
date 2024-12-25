using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс репозитория для работы с связями постов и тегов.
    /// Наследует базовые методы работы с сущностями из IRepositoryBase<PostTag>.
    public interface IPostTagRepository : IRepositoryBase<PostTag>
    {
     
    }
}