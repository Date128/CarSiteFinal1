using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с рекомендациями экспертов.
    [Route("api/[controller]")]
    [ApiController]
    public class ExpertRecommendationsController : ControllerBase
    {
        private readonly IExpertRecommendationService _expertRecommendationService;
        /// Конструктор контроллера ExpertRecommendationsController.
        /// <param name="expertRecommendationService">Сервис для работы с рекомендациями экспертов.</param>
        public ExpertRecommendationsController(IExpertRecommendationService expertRecommendationService)
        {
            _expertRecommendationService = expertRecommendationService;
        }

        /// Получает список всех рекомендаций экспертов.
        /// <returns>Список рекомендаций экспертов.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var expertRecommendations = await _expertRecommendationService.GetAll();
            return Ok(expertRecommendations);
        }

        /// Получает рекомендацию эксперта по ее идентификатору.
        /// <param name="id">Идентификатор рекомендации эксперта.</param>
        /// <returns>Рекомендация эксперта.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var expertRecommendation = await _expertRecommendationService.GetById(id);
            return Ok(expertRecommendation);
        }

        /// Добавляет новую рекомендацию эксперта.
        /// <param name="expertRecommendation">Модель рекомендации эксперта для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(ExpertRecommendation expertRecommendation)
        {
            await _expertRecommendationService.Create(expertRecommendation);
            return Ok();
        }

        /// Обновляет существующую рекомендацию эксперта.
        /// <param name="expertRecommendation">Модель рекомендации эксперта для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(ExpertRecommendation expertRecommendation)
        {
            await _expertRecommendationService.Update(expertRecommendation);
            return Ok();
        }

        /// Удаляет рекомендацию эксперта по ее идентификатору.
        /// <param name="id">Идентификатор рекомендации эксперта.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _expertRecommendationService.Delete(id);
            return Ok();
        }
    }
}