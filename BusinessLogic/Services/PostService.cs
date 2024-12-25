using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Post (пост).
    /// Реализует интерфейс IPostService.
    public class PostService : IPostService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public PostService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех постов.
        /// <returns>Список постов.</returns>
        public async Task<List<Post>> GetAll()
        {
            return await _repositoryWrapper.Post.FindAll();
        }

        /// Получает пост по его идентификатору.
        /// <param name="id">Идентификатор поста.</param>
        /// <returns>Пост.</returns>
        public async Task<Post> GetById(int id)
        {
            var post = await _repositoryWrapper.Post
                .FindByCondition(x => x.PostId == id);
            return post.First();
        }

        /// Создаёт новый пост.
        /// <param name="model">Модель поста.</param>
        public async Task Create(Post model)
        {
            await _repositoryWrapper.Post.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о посте.
        /// <param name="model">Модель поста с обновлёнными данными.</param>
        public async Task Update(Post model)
        {
            _repositoryWrapper.Post.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет пост по его идентификатору.
        /// <param name="id">Идентификатор поста.</param>
        public async Task Delete(int id)
        {
            var post = await _repositoryWrapper.Post
                .FindByCondition(x => x.PostId == id);

            _repositoryWrapper.Post.Delete(post.First());
            _repositoryWrapper.Save();
        }
    }
}