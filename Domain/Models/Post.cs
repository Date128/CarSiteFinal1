using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель поста.
public partial class Post
{
    /// Уникальный идентификатор поста.
    public int PostId { get; set; }

    /// Заголовок поста.
    public string Title { get; set; } = null!;

    /// Содержимое поста.
    public string Content { get; set; } = null!;

    /// Дата публикации поста. Может быть null, если дата не указана.
    public DateTime? PublicationDate { get; set; }

    /// Идентификатор автора поста. Может быть null, если автор не указан.
    public int? AuthorId { get; set; }

    /// Тип поста (например, новость, обзор, рекомендация эксперта и т.д.).
    public string PostType { get; set; } = null!;

    /// Идентификатор автомобиля, связанного с постом. Может быть null, если автомобиль не указан.
    public int? CarId { get; set; }

    /// Идентификатор категории, к которой относится пост. Может быть null, если категория не указана.
    public int? CategoryId { get; set; }

    /// Навигационное свойство для связи с автором поста.
    public virtual User? Author { get; set; }

    /// Навигационное свойство для связи с автомобилем.
    public virtual Car? Car { get; set; }

    /// Навигационное свойство для связи с категорией.
    public virtual Category? Category { get; set; }

    /// Коллекция комментариев, связанных с постом.
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    /// Навигационное свойство для связи с рекомендацией эксперта.
    public virtual ExpertRecommendation? ExpertRecommendation { get; set; }

    /// Навигационное свойство для связи с новостью.
    public virtual News? News { get; set; }

    /// Коллекция тегов, связанных с постом.
    public virtual ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();

    /// Коллекция рейтингов, связанных с постом.
    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    /// Навигационное свойство для связи с отзывом.
    public virtual Review? Review { get; set; }

    /// Навигационное свойство для связи с тест-драйвом.
    public virtual TestDrife? TestDrife { get; set; }
}