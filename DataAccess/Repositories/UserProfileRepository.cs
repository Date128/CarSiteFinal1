using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    /// Репозиторий для работы с сущностью UserProfile (профиль пользователя).
    /// Реализует интерфейс IUserProfileRepository.
    public class UserProfileRepository : RepositoryBase<UserProfile>, IUserProfileRepository
    {
        /// Конструктор репозитория.
        /// <param name="repositoryContext">Контекст базы данных, используемый для работы с данными.</param>
        public UserProfileRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}