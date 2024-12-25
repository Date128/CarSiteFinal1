using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с постами.
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        /// Конструктор контроллера PostsController.
        /// <param name="postService">Сервис для работы с постами.</param>
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        /// Получает список всех постов.
        /// <returns>Список постов.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postService.GetAll();
            return Ok(posts);
        }

        /// Получает пост по его идентификатору.
        /// <param name="id">Идентификатор поста.</param>
        /// <returns>Пост.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await _postService.GetById(id);
            return Ok(post);
        }

        /// Добавляет новый пост.
        /// <param name="post">Модель поста для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Post post)
        {
            await _postService.Create(post);
            return Ok();
        }

        /// Обновляет существующий пост.
        /// <param name="post">Модель поста для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Post post)
        {
            await _postService.Update(post);
            return Ok();
        }

        /// Удаляет пост по его идентификатору.
        /// <param name="id">Идентификатор поста.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _postService.Delete(id);
            return Ok();
        }
    }
}