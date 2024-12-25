using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью UserProfile (профиль пользователя).
    /// Реализует интерфейс IUserProfileService.
    public class UserProfileService : IUserProfileService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public UserProfileService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех профилей пользователей.
        /// <returns>Список профилей пользователей.</returns>
        public async Task<List<UserProfile>> GetAll()
        {
            return await _repositoryWrapper.UserProfile.FindAll();
        }

        /// Получает профиль пользователя по его идентификатору.
        /// <param name="id">Идентификатор профиля пользователя.</param>
        /// <returns>Профиль пользователя.</returns>
        public async Task<UserProfile> GetById(int id)
        {
            var userProfile = await _repositoryWrapper.UserProfile
                .FindByCondition(x => x.ProfileId == id);
            return userProfile.First();
        }

        /// Создаёт новый профиль пользователя.
        /// <param name="model">Модель профиля пользователя.</param>
        public async Task Create(UserProfile model)
        {
            await _repositoryWrapper.UserProfile.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о профиле пользователя.
        /// <param name="model">Модель профиля пользователя с обновлёнными данными.</param>
        public async Task Update(UserProfile model)
        {
            _repositoryWrapper.UserProfile.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет профиль пользователя по его идентификатору.
        /// <param name="id">Идентификатор профиля пользователя.</param>
        public async Task Delete(int id)
        {
            var userProfile = await _repositoryWrapper.UserProfile
                .FindByCondition(x => x.ProfileId == id);

            _repositoryWrapper.UserProfile.Delete(userProfile.First());
            _repositoryWrapper.Save();
        }
    }
}