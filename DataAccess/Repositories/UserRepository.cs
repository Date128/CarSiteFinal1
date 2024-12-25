using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью User (пользователь).
    /// Реализует интерфейс IUserRepository.
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public UserRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}