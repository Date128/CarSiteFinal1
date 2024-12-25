using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для тестовой поездки.
    public partial class TestDrife
    {
        /// Уникальный идентификатор тестовой поездки.
        public int TestDriveId { get; set; }

        /// Идентификатор автомобиля, связанного с тестовой поездкой.
        public int? CarId { get; set; }

        /// Связанный автомобиль.
        public virtual Car? Car { get; set; }

        /// Связанный пост, описывающий тестовую поездку.
        public virtual Post TestDrive { get; set; } = null!;
    }
}