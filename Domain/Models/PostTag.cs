using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель связи поста и тега.
public partial class PostTag
{
    /// Уникальный идентификатор связи поста и тега.
    public int PostTagId { get; set; }

    /// Идентификатор поста, к которому относится тег. Может быть null, если пост не указан.
    public int? PostId { get; set; }

    /// Идентификатор тега, связанного с постом. Может быть null, если тег не указан.
    public int? TagId { get; set; }

    /// Навигационное свойство для связи с постом.
    public virtual Post? Post { get; set; }

    /// Навигационное свойство для связи с тегом.
    public virtual Tag? Tag { get; set; }
}