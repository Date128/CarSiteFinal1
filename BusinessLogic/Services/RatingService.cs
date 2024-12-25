using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Rating (рейтинг).
    /// Реализует интерфейс IRatingService.
    public class RatingService : IRatingService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public RatingService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех рейтингов.
        /// <returns>Список рейтингов.</returns>
        public async Task<List<Rating>> GetAll()
        {
            return await _repositoryWrapper.Rating.FindAll();
        }

        /// Получает рейтинг по его идентификатору.
        /// <param name="id">Идентификатор рейтинга.</param>
        /// <returns>Рейтинг.</returns>
        public async Task<Rating> GetById(int id)
        {
            var rating = await _repositoryWrapper.Rating
                .FindByCondition(x => x.RatingId == id);
            return rating.First();
        }

        /// Создаёт новый рейтинг.
        /// <param name="model">Модель рейтинга.</param>
        public async Task Create(Rating model)
        {
            await _repositoryWrapper.Rating.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о рейтинге.
        /// <param name="model">Модель рейтинга с обновлёнными данными.</param>
        public async Task Update(Rating model)
        {
            _repositoryWrapper.Rating.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет рейтинг по его идентификатору.
        /// <param name="id">Идентификатор рейтинга.</param>
        public async Task Delete(int id)
        {
            var rating = await _repositoryWrapper.Rating
                .FindByCondition(x => x.RatingId == id);

            _repositoryWrapper.Rating.Delete(rating.First());
            _repositoryWrapper.Save();
        }
    }
}