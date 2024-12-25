using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с категориями.
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        /// Конструктор контроллера CategoriesController.
        /// <param name="categoryService">Сервис для работы с категориями.</param>
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// Получает список всех категорий.
        /// <returns>Список категорий.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAll();
            return Ok(categories);
        }

        /// Получает категорию по ее идентификатору.
        /// <param name="id">Идентификатор категории.</param>
        /// <returns>Категория.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetById(id);
            return Ok(category);
        }

        /// Добавляет новую категорию.
        /// <param name="category">Модель категории для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            await _categoryService.Create(category);
            return Ok();
        }

        /// Обновляет существующую категорию.
        /// <param name="category">Модель категории для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Category category)
        {
            await _categoryService.Update(category);
            return Ok();
        }

        /// Удаляет категорию по ее идентификатору.
        /// <param name="id">Идентификатор категории.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.Delete(id);
            return Ok();
        }
    }
}