using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для профиля пользователя.
    public partial class UserProfile
    {
        /// Уникальный идентификатор профиля.
        public int ProfileId { get; set; }

        /// Идентификатор пользователя, к которому относится профиль.
        public int? UserId { get; set; }

        /// Имя пользователя.
        public string FirstName { get; set; } = null!;

        /// Фамилия пользователя.
        public string LastName { get; set; } = null!;

        /// Дата рождения пользователя.
        public DateOnly? BirthDate { get; set; }

        /// Телефон пользователя.
        public string? Phone { get; set; }

        /// Адрес пользователя.
        public string? Address { get; set; }

        /// Биография пользователя.
        public string? Bio { get; set; }

        /// Связанный пользователь.
        public virtual User? User { get; set; }
    }
}