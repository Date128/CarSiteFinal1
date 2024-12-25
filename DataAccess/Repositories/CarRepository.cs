using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью Car (автомобиль).
    /// Реализует интерфейс ICarRepository.
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public CarRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
