using System;
using System.Collections.Generic;

namespace Domain.Models
{
    /// Модель данных для пользователя.
    public partial class User
    {
        /// Уникальный идентификатор пользователя.
        public int UserId { get; set; }

        /// Имя пользователя (логин).
        public string Username { get; set; } = null!;

        /// Электронная почта пользователя.
        public string Email { get; set; } = null!;

        /// Хэш пароля пользователя.
        public string PasswordHash { get; set; } = null!;

        /// Дата регистрации пользователя.
        public DateTime? RegistrationDate { get; set; }

        /// Роль пользователя (например, "Admin", "User").
        public string Role { get; set; } = null!;

        /// Коллекция арендованных автомобилей пользователем.
        public virtual ICollection<CarRental> CarRentals { get; set; } = new List<CarRental>();

        /// Коллекция автомобилей, купленных пользователем.
        public virtual ICollection<CarSale> CarSaleBuyers { get; set; } = new List<CarSale>();

        /// Коллекция автомобилей, проданных пользователем.
        public virtual ICollection<CarSale> CarSaleSellers { get; set; } = new List<CarSale>();

        /// Коллекция комментариев, оставленных пользователем.
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        /// Коллекция рекомендаций экспертов, связанных с пользователем.
        public virtual ICollection<ExpertRecommendation> ExpertRecommendations { get; set; } = new List<ExpertRecommendation>();

        /// Коллекция записей обслуживания, связанных с пользователем.
        public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();

        /// Коллекция уведомлений, связанных с пользователем.
        public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

        /// Коллекция постов, созданных пользователем.
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        /// Коллекция оценок, оставленных пользователем.
        public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

        /// Коллекция профилей пользователя.
        public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
    }
}