using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью CarRental (аренда автомобиля).
    /// Реализует интерфейс ICarRentalRepository.
    public class CarRentalRepository : RepositoryBase<CarRental>, ICarRentalRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public CarRentalRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}