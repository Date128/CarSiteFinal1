using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель комментария.
public partial class Comment
{
    /// Уникальный идентификатор комментария.
    public int CommentId { get; set; }

    /// Содержимое комментария.
    public string Content { get; set; } = null!;

    /// Дата публикации комментария. Может быть null, если дата не указана.
    public DateTime? PublicationDate { get; set; }

    /// Идентификатор пользователя, оставившего комментарий. Может быть null, если пользователь не указан.
    public int? UserId { get; set; }

    /// Идентификатор поста, к которому относится комментарий. Может быть null, если пост не указан.
    public int? PostId { get; set; }

    /// Тип поста, к которому относится комментарий (например, новость, обзор, рекомендация эксперта и т.д.).
    public string PostType { get; set; } = null!;

    /// Навигационное свойство для связи с постом.
    public virtual Post? Post { get; set; }

    /// Навигационное свойство для связи с пользователем.
    public virtual User? User { get; set; }
}