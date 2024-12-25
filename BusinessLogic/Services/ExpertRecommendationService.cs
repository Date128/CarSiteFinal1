using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью ExpertRecommendation (рекомендация эксперта).
    /// Реализует интерфейс IExpertRecommendationService.
    public class ExpertRecommendationService : IExpertRecommendationService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public ExpertRecommendationService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех рекомендаций экспертов.
        /// <returns>Список рекомендаций экспертов.</returns>
        public async Task<List<ExpertRecommendation>> GetAll()
        {
            return await _repositoryWrapper.ExpertRecommendation.FindAll();
        }

        /// Получает рекомендацию эксперта по её идентификатору.
        /// <param name="id">Идентификатор рекомендации эксперта.</param>
        /// <returns>Рекомендация эксперта.</returns>
        public async Task<ExpertRecommendation> GetById(int id)
        {
            var expertRecommendation = await _repositoryWrapper.ExpertRecommendation
                .FindByCondition(x => x.RecommendationId == id);
            return expertRecommendation.First();
        }

        /// Создаёт новую рекомендацию эксперта.
        /// <param name="model">Модель рекомендации эксперта.</param>
        public async Task Create(ExpertRecommendation model)
        {
            await _repositoryWrapper.ExpertRecommendation.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о рекомендации эксперта.
        /// <param name="model">Модель рекомендации эксперта с обновлёнными данными.</param>
        public async Task Update(ExpertRecommendation model)
        {
            _repositoryWrapper.ExpertRecommendation.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет рекомендацию эксперта по её идентификатору.
        /// <param name="id">Идентификатор рекомендации эксперта.</param>
        public async Task Delete(int id)
        {
            var expertRecommendation = await _repositoryWrapper.ExpertRecommendation
                .FindByCondition(x => x.RecommendationId == id);

            _repositoryWrapper.ExpertRecommendation.Delete(expertRecommendation.First());
            _repositoryWrapper.Save();
        }
    }
}