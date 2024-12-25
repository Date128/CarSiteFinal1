using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель отзыва.

public partial class Review
{
    /// Уникальный идентификатор отзыва.
    public int ReviewId { get; set; }

    /// Идентификатор автомобиля, к которому относится отзыв. Может быть null, если отзыв не привязан к конкретному автомобилю.
    public int? CarId { get; set; }

    /// Навигационное свойство для связи с автомобилем.
    public virtual Car? Car { get; set; }

    /// Навигационное свойство для связи с постом, содержащим отзыв.
    public virtual Post ReviewNavigation { get; set; } = null!;
}