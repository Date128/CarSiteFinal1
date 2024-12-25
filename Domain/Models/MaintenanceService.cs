using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для услуги обслуживания (MaintenanceService).
    public partial class MaintenanceService
    {
        /// Уникальный идентификатор услуги обслуживания.
        public int ServiceId { get; set; }

        /// Идентификатор сервисного центра, предоставляющего услугу.
        public int? CenterId { get; set; }

        /// Название услуги обслуживания.
        public string Name { get; set; } = null!;

        /// Описание услуги обслуживания.
        public string Description { get; set; } = null!;

        /// Стоимость услуги обслуживания.
        public decimal Price { get; set; }

        /// Связанный сервисный центр.
        public virtual ServiceCenter? Center { get; set; }
    }
}