using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель атрибута, который может быть связан с автомобилями.
public partial class Attribute
{
    /// Уникальный идентификатор атрибута.
    public int AttributeId { get; set; }

    /// Тип значения атрибута (например, текст, число, дата и т.д.).
    public string TypeValue { get; set; } = null!;

    /// Название атрибута.
    public string Name { get; set; } = null!;

    /// Коллекция связей атрибута с автомобилями.
    public virtual ICollection<CarAttribute> CarAttributes { get; set; } = new List<CarAttribute>();
}