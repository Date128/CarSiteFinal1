using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью CarImage (изображение автомобиля).
    /// Реализует интерфейс ICarImageRepository.
    public class CarImageRepository : RepositoryBase<CarImage>, ICarImageRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public CarImageRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}