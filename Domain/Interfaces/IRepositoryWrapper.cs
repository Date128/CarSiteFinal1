using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Wrapper
{
    /// Интерфейс обёртки репозиториев, предоставляющий доступ к различным репозиториям.
    public interface IRepositoryWrapper
    {
        /// Репозиторий для работы с пользователями.
        IUserRepository User { get; }

        /// Репозиторий для работы с автомобилями.
        ICarRepository Car { get; }

        /// Репозиторий для работы с категориями.
        ICategoryRepository Category { get; }

        /// Репозиторий для работы с тегами.
        ITagRepository Tag { get; }

        /// Репозиторий для работы с атрибутами.
        IAttributeRepository Attribute { get; }

        /// Репозиторий для работы с атрибутами автомобилей.
        ICarAttributeRepository CarAttribute { get; }

        /// Репозиторий для работы с изображениями автомобилей.
        ICarImageRepository CarImage { get; }

        /// Репозиторий для работы с арендой автомобилей.
        ICarRentalRepository CarRental { get; }

        /// Репозиторий для работы с продажей автомобилей.
        ICarSaleRepository CarSale { get; }

        /// Репозиторий для работы с комментариями.
        ICommentRepository Comment { get; }

        /// Репозиторий для работы с новостями.
        INewsRepository News { get; }

        /// Репозиторий для работы с постами.
        IPostRepository Post { get; }

        /// Репозиторий для работы с тегами постов.
        IPostTagRepository PostTag { get; }

        /// Репозиторий для работы с рейтингами.
        IRatingRepository Rating { get; }

        /// Репозиторий для работы с отзывами.
        IReviewRepository Review { get; }

        /// Репозиторий для работы с сервисными центрами.
        IServiceCenterRepository ServiceCenter { get; }

        /// Репозиторий для работы с техническим обслуживанием.
        ITechnicalMaintenanceRepository TechnicalMaintenance { get; }

        /// Репозиторий для работы с тестовыми поездками.
        ITestDrifeRepository TestDrife { get; }

        /// Репозиторий для работы с профилями пользователей.
        IUserProfileRepository UserProfile { get; }

        /// Репозиторий для работы с рекомендациями экспертов.
        IExpertRecommendationRepository ExpertRecommendation { get; }

        /// Репозиторий для работы с записями обслуживания.
        IMaintenanceRecordRepository MaintenanceRecord { get; }

        /// Репозиторий для работы с услугами обслуживания.
        IMaintenanceServiceRepository MaintenanceService { get; }

        /// Репозиторий для работы с уведомлениями.
        INotificationRepository Notification { get; }

        /// Сохраняет изменения в базе данных.
        Task Save();
    }
}