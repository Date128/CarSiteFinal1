using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для уведомления (Notification).
    public partial class Notification
    {
        /// Уникальный идентификатор уведомления.
        public int NotificationId { get; set; }

        /// Идентификатор пользователя, связанного с уведомлением.
        public int? UserId { get; set; }

        /// Текст уведомления.
        public string Message { get; set; } = null!;

        /// Дата и время создания уведомления.
        public DateTime? Date { get; set; }

        /// Флаг, указывающий, прочитано ли уведомление.
        public bool? IsRead { get; set; }

        /// Связанный пользователь.
        public virtual User? User { get; set; }
    }
}