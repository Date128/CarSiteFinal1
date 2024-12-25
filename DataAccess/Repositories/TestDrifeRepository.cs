using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью TestDrife (тестовая поездка).
    /// Реализует интерфейс ITestDrifeRepository.
    public class TestDrifeRepository : RepositoryBase<TestDrife>, ITestDrifeRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public TestDrifeRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}