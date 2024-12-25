using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с новостями.
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        /// Конструктор контроллера NewsController.
        /// <param name="newsService">Сервис для работы с новостями.</param>
        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        /// Получает список всех новостей.
        /// <returns>Список новостей.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var news = await _newsService.GetAll();
            return Ok(news);
        }

        /// Получает новость по ее идентификатору.
        /// <param name="id">Идентификатор новости.</param>
        /// <returns>Новость.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var newsItem = await _newsService.GetById(id);
            return Ok(newsItem);
        }

        /// Добавляет новую новость.
        /// <param name="news">Модель новости для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(News news)
        {
            await _newsService.Create(news);
            return Ok();
        }

        /// Обновляет существующую новость.
        /// <param name="news">Модель новости для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(News news)
        {
            await _newsService.Update(news);
            return Ok();
        }

        /// Удаляет новость по ее идентификатору.
        /// <param name="id">Идентификатор новости.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _newsService.Delete(id);
            return Ok();
        }
    }
}