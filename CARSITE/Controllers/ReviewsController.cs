using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с отзывами.
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        /// Конструктор контроллера ReviewsController.
        /// <param name="reviewService">Сервис для работы с отзывами.</param>
        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        /// Получает список всех отзывов.
        /// <returns>Список отзывов.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reviews = await _reviewService.GetAll();
            return Ok(reviews);
        }

        /// Получает отзыв по его идентификатору.
        /// <param name="id">Идентификатор отзыва.</param>
        /// <returns>Отзыв.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var review = await _reviewService.GetById(id);
            return Ok(review);
        }

        /// Добавляет новый отзыв.
        /// <param name="review">Модель отзыва для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Review review)
        {
            await _reviewService.Create(review);
            return Ok();
        }

        /// Обновляет существующий отзыв.
        /// <param name="review">Модель отзыва для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Review review)
        {
            await _reviewService.Update(review);
            return Ok();
        }

        /// Удаляет отзыв по его идентификатору.
        /// <param name="id">Идентификатор отзыва.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _reviewService.Delete(id);
            return Ok();
        }
    }
}