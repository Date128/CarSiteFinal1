using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель категории, которая используется для группировки новостей и постов.
public partial class Category
{
    /// Уникальный идентификатор категории.
    public int CategoryId { get; set; }

    /// Название категории.
    public string Name { get; set; } = null!;

    /// Коллекция новостей, связанных с данной категорией.
    public virtual ICollection<News> News { get; set; } = new List<News>();

    /// Коллекция постов, связанных с данной категорией.
    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}