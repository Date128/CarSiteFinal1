using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для изображения автомобиля (CarImage).
    public partial class CarImage
    {
        /// Уникальный идентификатор изображения.
        public int ImageId { get; set; }

        /// Идентификатор автомобиля, связанного с изображением.
        public int? CarId { get; set; }

        /// URL-адрес изображения.
        public string ImageUrl { get; set; } = null!;

        /// Описание изображения (необязательное поле).
        public string? Description { get; set; }

        /// Связанный автомобиль.
        public virtual Car? Car { get; set; }
    }
}
