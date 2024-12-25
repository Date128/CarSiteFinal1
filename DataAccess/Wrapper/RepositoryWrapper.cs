using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using DataAccess.Repositories;
using Domain.Wrapper;

namespace DataAccess.Wrapper
{
    /// Обёртка для всех репозиториев, предоставляющая доступ к репозиториям через свойства.
    /// Реализует интерфейс IRepositoryWrapper.
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private CarsiteContext _repoContext;

        private IUserRepository _user;
        private ICarRepository _car;
        private ICategoryRepository _category;
        private IAttributeRepository _attribute;
        private ICarAttributeRepository _carAttribute;
        private ICarImageRepository _carImage;
        private ICarRentalRepository _carRental;
        private ICarSaleRepository _carSale;
        private ICommentRepository _comment;
        private INewsRepository _news;
        private IPostRepository _post;
        private IPostTagRepository _postTag;
        private IRatingRepository _rating;
        private IReviewRepository _review;
        private IServiceCenterRepository _serviceCenter;
        private ITagRepository _tag;
        private ITechnicalMaintenanceRepository _technicalMaintenance;
        private ITestDrifeRepository _testDrife;
        private IUserProfileRepository _userProfile;
        private IExpertRecommendationRepository _expertRecommendation;
        private IMaintenanceRecordRepository _maintenanceRecord;
        private IMaintenanceServiceRepository _maintenanceService;
        private INotificationRepository _notification;

        /// Репозиторий для работы с уведомлениями.
        public INotificationRepository Notification
        {
            get
            {
                if (_notification == null)
                {
                    _notification = new NotificationRepository(_repoContext);
                }
                return _notification;
            }
        }

        /// Репозиторий для работы с услугами обслуживания.
        public IMaintenanceServiceRepository MaintenanceService
        {
            get
            {
                if (_maintenanceService == null)
                {
                    _maintenanceService = new MaintenanceServiceRepository(_repoContext);
                }
                return _maintenanceService;
            }
        }

        /// Репозиторий для работы с записями обслуживания.
        public IMaintenanceRecordRepository MaintenanceRecord
        {
            get
            {
                if (_maintenanceRecord == null)
                {
                    _maintenanceRecord = new MaintenanceRecordRepository(_repoContext);
                }
                return _maintenanceRecord;
            }
        }

        /// Репозиторий для работы с рекомендациями экспертов.
        public IExpertRecommendationRepository ExpertRecommendation
        {
            get
            {
                if (_expertRecommendation == null)
                {
                    _expertRecommendation = new ExpertRecommendationRepository(_repoContext);
                }
                return _expertRecommendation;
            }
        }

        /// Репозиторий для работы с пользователями.
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }

        /// Репозиторий для работы с автомобилями.
        public ICarRepository Car
        {
            get
            {
                if (_car == null)
                {
                    _car = new CarRepository(_repoContext);
                }
                return _car;
            }
        }

        /// Репозиторий для работы с категориями.
        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext);
                }
                return _category;
            }
        }

        /// Репозиторий для работы с тегами.
        public ITagRepository Tag
        {
            get
            {
                if (_tag == null)
                {
                    _tag = new TagRepository(_repoContext);
                }
                return _tag;
            }
        }

        /// Репозиторий для работы с атрибутами.
        public IAttributeRepository Attribute
        {
            get
            {
                if (_attribute == null)
                {
                    _attribute = new AttributeRepository(_repoContext);
                }
                return _attribute;
            }
        }

        /// Репозиторий для работы с атрибутами автомобилей.
        public ICarAttributeRepository CarAttribute
        {
            get
            {
                if (_carAttribute == null)
                {
                    _carAttribute = new CarAttributeRepository(_repoContext);
                }
                return _carAttribute;
            }
        }

        /// Репозиторий для работы с изображениями автомобилей.
        public ICarImageRepository CarImage
        {
            get
            {
                if (_carImage == null)
                {
                    _carImage = new CarImageRepository(_repoContext);
                }
                return _carImage;
            }
        }

        /// Репозиторий для работы с арендой автомобилей.
        public ICarRentalRepository CarRental
        {
            get
            {
                if (_carRental == null)
                {
                    _carRental = new CarRentalRepository(_repoContext);
                }
                return _carRental;
            }
        }

        /// Репозиторий для работы с продажей автомобилей.
        public ICarSaleRepository CarSale
        {
            get
            {
                if (_carSale == null)
                {
                    _carSale = new CarSaleRepository(_repoContext);
                }
                return _carSale;
            }
        }

        /// Репозиторий для работы с комментариями.
        public ICommentRepository Comment
        {
            get
            {
                if (_comment == null)
                {
                    _comment = new CommentRepository(_repoContext);
                }
                return _comment;
            }
        }

        /// Репозиторий для работы с новостями.
        public INewsRepository News
        {
            get
            {
                if (_news == null)
                {
                    _news = new NewsRepository(_repoContext);
                }
                return _news;
            }
        }

        /// Репозиторий для работы с постами.
        public IPostRepository Post
        {
            get
            {
                if (_post == null)
                {
                    _post = new PostRepository(_repoContext);
                }
                return _post;
            }
        }

        /// Репозиторий для работы с тегами постов.
        public IPostTagRepository PostTag
        {
            get
            {
                if (_postTag == null)
                {
                    _postTag = new PostTagRepository(_repoContext);
                }
                return _postTag;
            }
        }

        /// Репозиторий для работы с рейтингами.
        public IRatingRepository Rating
        {
            get
            {
                if (_rating == null)
                {
                    _rating = new RatingRepository(_repoContext);
                }
                return _rating;
            }
        }

        /// Репозиторий для работы с отзывами.
        public IReviewRepository Review
        {
            get
            {
                if (_review == null)
                {
                    _review = new ReviewRepository(_repoContext);
                }
                return _review;
            }
        }

        /// Репозиторий для работы с сервисными центрами.
        public IServiceCenterRepository ServiceCenter
        {
            get
            {
                if (_serviceCenter == null)
                {
                    _serviceCenter = new ServiceCenterRepository(_repoContext);
                }
                return _serviceCenter;
            }
        }

        /// Репозиторий для работы с техническим обслуживанием.
        public ITechnicalMaintenanceRepository TechnicalMaintenance
        {
            get
            {
                if (_technicalMaintenance == null)
                {
                    _technicalMaintenance = new TechnicalMaintenanceRepository(_repoContext);
                }
                return _technicalMaintenance;
            }
        }

        /// Репозиторий для работы с тестовыми поездками.
        public ITestDrifeRepository TestDrife
        {
            get
            {
                if (_testDrife == null)
                {
                    _testDrife = new TestDrifeRepository(_repoContext);
                }
                return _testDrife;
            }
        }

        /// Репозиторий для работы с профилями пользователей.
        public IUserProfileRepository UserProfile
        {
            get
            {
                if (_userProfile == null)
                {
                    _userProfile = new UserProfileRepository(_repoContext);
                }
                return _userProfile;
            }
        }

        /// Конструктор обёртки репозиториев.
        /// <param name="repositoryContext">Контекст базы данных.</param>
        public RepositoryWrapper(CarsiteContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        /// Сохраняет изменения в базе данных.
        public async Task Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}