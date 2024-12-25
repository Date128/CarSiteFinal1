using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью PostTag (тег поста).
    /// Реализует интерфейс IPostTagService.
    public class PostTagService : IPostTagService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public PostTagService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех связей между постами и тегами.
        /// <returns>Список связей между постами и тегами.</returns>
        public async Task<List<PostTag>> GetAll()
        {
            return await _repositoryWrapper.PostTag.FindAll();
        }

        /// Получает связь между постом и тегом по её идентификатору.
        /// <param name="id">Идентификатор связи между постом и тегом.</param>
        /// <returns>Связь между постом и тегом.</returns>
        public async Task<PostTag> GetById(int id)
        {
            var postTag = await _repositoryWrapper.PostTag
                .FindByCondition(x => x.PostTagId == id);
            return postTag.First();
        }

        /// Создаёт новую связь между постом и тегом.
        /// <param name="model">Модель связи между постом и тегом.</param>
        public async Task Create(PostTag model)
        {
            await _repositoryWrapper.PostTag.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о связи между постом и тегом.
        /// <param name="model">Модель связи между постом и тегом с обновлёнными данными.</param>
        public async Task Update(PostTag model)
        {
            _repositoryWrapper.PostTag.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет связь между постом и тегом по её идентификатору.
        /// <param name="id">Идентификатор связи между постом и тегом.</param>
        public async Task Delete(int id)
        {
            var postTag = await _repositoryWrapper.PostTag
                .FindByCondition(x => x.PostTagId == id);

            _repositoryWrapper.PostTag.Delete(postTag.First());
            _repositoryWrapper.Save();
        }
    }
}