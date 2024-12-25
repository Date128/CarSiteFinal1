using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с комментариями.
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        /// Конструктор контроллера CommentsController.
        /// <param name="commentService">Сервис для работы с комментариями.</param>
        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        /// Получает список всех комментариев.
        /// <returns>Список комментариев.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _commentService.GetAll();
            return Ok(comments);
        }

        /// Получает комментарий по его идентификатору.
        /// <param name="id">Идентификатор комментария.</param>
        /// <returns>Комментарий.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var comment = await _commentService.GetById(id);
            return Ok(comment);
        }

        /// Добавляет новый комментарий.
        /// <param name="comment">Модель комментария для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Comment comment)
        {
            await _commentService.Create(comment);
            return Ok();
        }

        /// Обновляет существующий комментарий.
        /// <param name="comment">Модель комментария для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Comment comment)
        {
            await _commentService.Update(comment);
            return Ok();
        }

        /// Удаляет комментарий по его идентификатору.
        /// <param name="id">Идентификатор комментария.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _commentService.Delete(id);
            return Ok();
        }
    }
}