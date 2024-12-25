using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с рейтингами.
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        /// Конструктор контроллера RatingsController.
        /// <param name="ratingService">Сервис для работы с рейтингами.</param>
        public RatingsController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        /// Получает список всех рейтингов.
        /// <returns>Список рейтингов.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ratings = await _ratingService.GetAll();
            return Ok(ratings);
        }

        /// Получает рейтинг по его идентификатору.
        /// <param name="id">Идентификатор рейтинга.</param>
        /// <returns>Рейтинг.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var rating = await _ratingService.GetById(id);
            return Ok(rating);
        }

        /// Добавляет новый рейтинг.
        /// <param name="rating">Модель рейтинга для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Rating rating)
        {
            await _ratingService.Create(rating);
            return Ok();
        }

        /// Обновляет существующий рейтинг.
        /// <param name="rating">Модель рейтинга для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Rating rating)
        {
            await _ratingService.Update(rating);
            return Ok();
        }

        /// Удаляет рейтинг по его идентификатору.
        /// <param name="id">Идентификатор рейтинга.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _ratingService.Delete(id);
            return Ok();
        }
    }
}