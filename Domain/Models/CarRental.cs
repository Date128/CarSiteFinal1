using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для аренды автомобиля (CarRental).
    public partial class CarRental
    {
        /// Уникальный идентификатор аренды.
        public int RentalId { get; set; }

        /// Идентификатор автомобиля, связанного с арендой.
        public int? CarId { get; set; }

        /// Идентификатор пользователя, арендующего автомобиль.
        public int? UserId { get; set; }

        /// Дата начала аренды.
        public DateTime StartDate { get; set; }

        /// Дата окончания аренды.
        public DateTime EndDate { get; set; }

        /// Стоимость аренды за день.
        public decimal PricePerDay { get; set; }

        /// Статус аренды (например, "Активна", "Завершена").
        public string Status { get; set; } = null!;

        /// Связанный автомобиль.
        public virtual Car? Car { get; set; }

        /// Связанный пользователь.
        public virtual User? User { get; set; }
    }
}