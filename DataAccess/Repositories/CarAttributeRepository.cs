using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью CarAttribute (атрибуты автомобиля).
    /// Реализует интерфейс ICarAttributeRepository.
    public class CarAttributeRepository : RepositoryBase<CarAttribute>, ICarAttributeRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public CarAttributeRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}