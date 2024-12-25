using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель новости.
public partial class News
{
    /// Уникальный идентификатор новости.
    public int NewsId { get; set; }

    /// Идентификатор категории, к которой относится новость. Может быть null, если категория не указана.
    public int? CategoryId { get; set; }

    /// Навигационное свойство для связи с категорией.
    public virtual Category? Category { get; set; }

    /// Навигационное свойство для связи с постом, содержащим новость.
    public virtual Post NewsNavigation { get; set; } = null!;
}