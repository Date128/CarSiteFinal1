
using Domain.Interfaces;
using BusinessLogic.Services;
using Domain.Models;
using DataAccess.Wrapper;
using Microsoft.EntityFrameworkCore;
using Domain.Wrapper;

namespace CARSITE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Настройка контекста базы данных
            builder.Services.AddDbContext<CarsiteContext>(
                options => options.UseSqlServer(builder.Configuration["ConnectionString"]));

            // Регистрация репозиториев
            builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            // Регистрация сервисов
            builder.Services.AddScoped<IUserService, UserService>(); // Сервис для работы с пользователями
            builder.Services.AddScoped<ICarServices, CarService>(); // Сервис для работы с автомобилями
            builder.Services.AddScoped<IPostService, PostService>(); // Сервис для работы с постами
            builder.Services.AddScoped<ICategoryService, CategoryService>(); // Сервис для работы с категориями
            builder.Services.AddScoped<ICommentService, CommentService>(); // Сервис для работы с комментариями
            builder.Services.AddScoped<ICarRentalService, CarRentalService>(); // Сервис для работы с арендой автомобилей
            builder.Services.AddScoped<ICarSaleService, CarSaleService>(); // Сервис для работы с продажей автомобилей
            builder.Services.AddScoped<IMaintenanceRecordService, MaintenanceRecordService>(); // Сервис для работы с записями обслуживания
            builder.Services.AddScoped<IServiceCenterService, ServiceCenterService>(); // Сервис для работы с сервисными центрами
            builder.Services.AddScoped<IMaintenanceServiceService, MaintenanceServiceService>(); // Сервис для работы с услугами обслуживания
            builder.Services.AddScoped<IUserProfileService, UserProfileService>(); // Сервис для работы с профилями пользователей
            builder.Services.AddScoped<ICarImageService, CarImageService>(); // Сервис для работы с изображениями автомобилей
            builder.Services.AddScoped<ITagService, TagService>(); // Сервис для работы с тегами
            builder.Services.AddScoped<IPostTagService, PostTagService>(); // Сервис для работы с тегами постов
            builder.Services.AddScoped<INotificationService, NotificationService>(); // Сервис для работы с уведомлениями
            builder.Services.AddScoped<IRatingService, RatingService>(); // Сервис для работы с рейтингами
            builder.Services.AddScoped<ITechnicalMaintenanceService, TechnicalMaintenanceService>(); // Сервис для работы с техническим обслуживанием
            builder.Services.AddScoped<ICarAttributeService, CarAttributeService>(); // Сервис для работы с атрибутами автомобилей
            builder.Services.AddScoped<IAttributeServise, AttributeServise>(); // Сервис для работы с атрибутами
            builder.Services.AddScoped<INewsService, NewsService>(); // Сервис для работы с новостями
            builder.Services.AddScoped<IReviewService, ReviewService>(); // Сервис для работы с отзывами
            builder.Services.AddScoped<ITestDriveService, TestDriveService>(); // Сервис для работы с тестовыми поездками
            builder.Services.AddScoped<IExpertRecommendationService, ExpertRecommendationService>(); // Сервис для работы с рекомендациями экспертов

            builder.Services.AddControllers();
            // Настройка Swagger/OpenAPI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Применение миграций базы данных
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<CarsiteContext>();
                context.Database.Migrate();
            }

            // Настройка HTTP-запросов
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}