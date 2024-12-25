using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью News (новость).
    /// Реализует интерфейс INewsService.
    public class NewsService : INewsService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public NewsService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех новостей.
        /// <returns>Список новостей.</returns>
        public async Task<List<News>> GetAll()
        {
            return await _repositoryWrapper.News.FindAll();
        }

        /// Получает новость по её идентификатору.
        /// <param name="id">Идентификатор новости.</param>
        /// <returns>Новость.</returns>
        public async Task<News> GetById(int id)
        {
            var news = await _repositoryWrapper.News
                .FindByCondition(x => x.NewsId == id);
            return news.First();
        }

        /// Создаёт новую новость.
        /// <param name="model">Модель новости.</param>
        public async Task Create(News model)
        {
            await _repositoryWrapper.News.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о новости.
        /// <param name="model">Модель новости с обновлёнными данными.</param>
        public async Task Update(News model)
        {
            _repositoryWrapper.News.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет новость по её идентификатору.
        /// <param name="id">Идентификатор новости.</param>
        public async Task Delete(int id)
        {
            var news = await _repositoryWrapper.News
                .FindByCondition(x => x.NewsId == id);

            _repositoryWrapper.News.Delete(news.First());
            _repositoryWrapper.Save();
        }
    }
}