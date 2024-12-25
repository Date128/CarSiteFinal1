using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Comment (комментарий).
    /// Реализует интерфейс ICommentService.
    public class CommentService : ICommentService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public CommentService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех комментариев.
        /// <returns>Список комментариев.</returns>
        public async Task<List<Comment>> GetAll()
        {
            return await _repositoryWrapper.Comment.FindAll();
        }

        /// Получает комментарий по его идентификатору.
        /// <param name="id">Идентификатор комментария.</param>
        /// <returns>Комментарий.</returns>
        public async Task<Comment> GetById(int id)
        {
            var comment = await _repositoryWrapper.Comment
                .FindByCondition(x => x.CommentId == id);
            return comment.First();
        }

        /// Создаёт новый комментарий.
        /// <param name="model">Модель комментария.</param>
        public async Task Create(Comment model)
        {
            await _repositoryWrapper.Comment.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о комментарии.
        /// <param name="model">Модель комментария с обновлёнными данными.</param>
        public async Task Update(Comment model)
        {
            _repositoryWrapper.Comment.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет комментарий по его идентификатору.
        /// <param name="id">Идентификатор комментария.</param>
        public async Task Delete(int id)
        {
            var comment = await _repositoryWrapper.Comment
                .FindByCondition(x => x.CommentId == id);

            _repositoryWrapper.Comment.Delete(comment.First());
            _repositoryWrapper.Save();
        }
    }
}