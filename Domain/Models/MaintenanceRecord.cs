using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для записи обслуживания (MaintenanceRecord).
    public partial class MaintenanceRecord
    {
        /// Уникальный идентификатор записи обслуживания.
        public int RecordId { get; set; }

        /// Идентификатор автомобиля, связанного с записью обслуживания.
        public int? CarId { get; set; }

        /// Идентификатор пользователя, связанного с записью обслуживания.
        public int? UserId { get; set; }

        /// Дата выполнения обслуживания.
        public DateTime ServiceDate { get; set; }

        /// Описание выполненного обслуживания.
        public string Description { get; set; } = null!;

        /// Стоимость обслуживания.
        public decimal Cost { get; set; }

        /// Связанный автомобиль.
        public virtual Car? Car { get; set; }

        /// Связанный пользователь.
        public virtual User? User { get; set; }
    }
}