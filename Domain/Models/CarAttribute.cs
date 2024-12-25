using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Класс, представляющий связь между автомобилем и его атрибутом.
public partial class CarAttribute
{
    /// Идентификатор автомобиля.
    public int CarId { get; set; }

    /// Идентификатор атрибута.
    public int AttributeId { get; set; }

    /// Значение атрибута для конкретного автомобиля.
    public string Value { get; set; } = null!;

    /// Навигационное свойство для связи с сущностью атрибута.
    public virtual Attribute Attribute { get; set; } = null!;

    /// Навигационное свойство для связи с сущностью автомобиля.
    public virtual Car Car { get; set; } = null!;
}
