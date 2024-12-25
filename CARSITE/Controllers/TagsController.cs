using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с тегами.
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagService;

        /// Конструктор контроллера TagsController.
        /// <param name="tagService">Сервис для работы с тегами.</param>
        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        /// Получает список всех тегов.
        /// <returns>Список тегов.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tags = await _tagService.GetAll();
            return Ok(tags);
        }

        /// Получает тег по его идентификатору.
        /// <param name="id">Идентификатор тега.</param>
        /// <returns>Тег.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tag = await _tagService.GetById(id);
            return Ok(tag);
        }

        /// Добавляет новый тег.
        /// <param name="tag">Модель тега для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Tag tag)
        {
            await _tagService.Create(tag);
            return Ok();
        }

        /// Обновляет существующий тег.
        /// <param name="tag">Модель тега для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Tag tag)
        {
            await _tagService.Update(tag);
            return Ok();
        }

        /// Удаляет тег по его идентификатору.
        /// <param name="id">Идентификатор тега.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _tagService.Delete(id);
            return Ok();
        }
    }
}