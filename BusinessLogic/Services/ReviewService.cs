using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Review (отзыв).
    /// Реализует интерфейс IReviewService.
    public class ReviewService : IReviewService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public ReviewService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех отзывов.
        /// <returns>Список отзывов.</returns>
        public async Task<List<Review>> GetAll()
        {
            return await _repositoryWrapper.Review.FindAll();
        }

        /// Получает отзыв по его идентификатору.
        /// <param name="id">Идентификатор отзыва.</param>
        /// <returns>Отзыв.</returns>
        public async Task<Review> GetById(int id)
        {
            var review = await _repositoryWrapper.Review
                .FindByCondition(x => x.ReviewId == id);
            return review.First();
        }

        /// Создаёт новый отзыв.
        /// <param name="model">Модель отзыва.</param>
        public async Task Create(Review model)
        {
            await _repositoryWrapper.Review.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию об отзыве.
        /// <param name="model">Модель отзыва с обновлёнными данными.</param>
        public async Task Update(Review model)
        {
            _repositoryWrapper.Review.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет отзыв по его идентификатору.
        /// <param name="id">Идентификатор отзыва.</param>
        public async Task Delete(int id)
        {
            var review = await _repositoryWrapper.Review
                .FindByCondition(x => x.ReviewId == id);

            _repositoryWrapper.Review.Delete(review.First());
            _repositoryWrapper.Save();
        }
    }
}