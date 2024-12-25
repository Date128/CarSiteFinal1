using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для тега.
    public partial class Tag
    {
        /// Уникальный идентификатор тега.
        public int TagId { get; set; }

        /// Название тега.
        public string Name { get; set; } = null!;

        /// Коллекция связей между тегом и постами.
        public virtual ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}