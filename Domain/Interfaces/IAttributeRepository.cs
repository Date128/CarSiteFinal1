﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс репозитория для работы с атрибутами.
    /// Наследует базовые методы работы с сущностями из IRepositoryBase<Attribute>.
    public interface IAttributeRepository : IRepositoryBase<Domain.Models.Attribute>
    {


    }
}