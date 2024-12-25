using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью User (пользователь).
    /// Реализует интерфейс IUserService.
    public class UserService : IUserService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public UserService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех пользователей.
        /// <returns>Список пользователей.</returns>
        public async Task<List<User>> GetAll()
        {
            return await _repositoryWrapper.User.FindAll();
        }

        /// Получает пользователя по его идентификатору.
        /// <param name="id">Идентификатор пользователя.</param>
        /// <returns>Пользователь.</returns>
        public async Task<User> GetById(int id)
        {
            var user = await _repositoryWrapper.User
                .FindByCondition(x => x.UserId == id);
            return user.First();
        }

        /// Создаёт нового пользователя.
        /// <param name="model">Модель пользователя.</param>
        public async Task Create(User model)
        {
            await _repositoryWrapper.User.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о пользователе.
        /// <param name="model">Модель пользователя с обновлёнными данными.</param>
        public async Task Update(User model)
        {
            _repositoryWrapper.User.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет пользователя по его идентификатору.
        /// <param name="id">Идентификатор пользователя.</param>
        public async Task Delete(int id)
        {
            var user = await _repositoryWrapper.User
                .FindByCondition(x => x.UserId == id);

            _repositoryWrapper.User.Delete(user.First());
            _repositoryWrapper.Save();
        }
    }
}