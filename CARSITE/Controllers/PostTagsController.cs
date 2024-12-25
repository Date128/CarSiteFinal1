using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с тегами постов.
    [Route("api/[controller]")]
    [ApiController]
    public class PostTagsController : ControllerBase
    {
        private readonly IPostTagService _postTagService;

        /// Конструктор контроллера PostTagsController.
        /// <param name="postTagService">Сервис для работы с тегами постов.</param>
        public PostTagsController(IPostTagService postTagService)
        {
            _postTagService = postTagService;
        }

        /// Получает список всех связей тегов с постами.
        /// <returns>Список связей тегов с постами.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var postTags = await _postTagService.GetAll();
            return Ok(postTags);
        }

        /// Получает связь тега с постом по ее идентификатору.
        /// <param name="id">Идентификатор связи тега с постом.</param>
        /// <returns>Связь тега с постом.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var postTag = await _postTagService.GetById(id);
            return Ok(postTag);
        }

        /// Добавляет новую связь тега с постом.
        /// <param name="postTag">Модель связи тега с постом для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(PostTag postTag)
        {
            await _postTagService.Create(postTag);
            return Ok();
        }

        /// Обновляет существующую связь тега с постом.
        /// <param name="postTag">Модель связи тега с постом для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(PostTag postTag)
        {
            await _postTagService.Update(postTag);
            return Ok();
        }

        /// Удаляет связь тега с постом по ее идентификатору.
        /// <param name="id">Идентификатор связи тега с постом.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _postTagService.Delete(id);
            return Ok();
        }
    }
}