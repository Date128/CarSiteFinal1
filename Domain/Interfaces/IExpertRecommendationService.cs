using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с рекомендациями экспертов.
    public interface IExpertRecommendationService
    {
        /// Получает список всех рекомендаций экспертов.
        /// <returns>Список рекомендаций экспертов.</returns>
        Task<List<ExpertRecommendation>> GetAll();

        /// Получает рекомендацию эксперта по ее идентификатору.
        /// <param name="id">Идентификатор рекомендации эксперта.</param>
        /// <returns>Рекомендация эксперта.</returns>
        Task<ExpertRecommendation> GetById(int id);

        /// Создает новую рекомендацию эксперта.
        /// <param name="model">Модель рекомендации эксперта для создания.</param>
        Task Create(ExpertRecommendation model);

        /// Обновляет существующую рекомендацию эксперта.
        /// <param name="model">Модель рекомендации эксперта для обновления.</param>
        Task Update(ExpertRecommendation model);

        /// Удаляет рекомендацию эксперта по ее идентификатору.
        /// <param name="id">Идентификатор рекомендации эксперта.</param>
        Task Delete(int id);
    }
}