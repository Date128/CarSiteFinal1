using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью CarSale (продажа автомобиля).
    /// Реализует интерфейс ICarSaleRepository.
    public class CarSaleRepository : RepositoryBase<CarSale>, ICarSaleRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public CarSaleRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}