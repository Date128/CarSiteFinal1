using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель рейтинга.
public partial class Rating
{
    /// Уникальный идентификатор рейтинга.
    public int RatingId { get; set; }

    /// Идентификатор пользователя, который поставил рейтинг. Может быть null, если пользователь не указан.
    public int? UserId { get; set; }

    /// Идентификатор поста, к которому относится рейтинг. Может быть null, если пост не указан.
    public int? PostId { get; set; }

    /// Значение рейтинга.
    public int Rating1 { get; set; }

    /// Навигационное свойство для связи с постом.
    public virtual Post? Post { get; set; }

    /// Навигационное свойство для связи с пользователем.
    public virtual User? User { get; set; }
}