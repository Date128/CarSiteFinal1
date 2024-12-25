using Domain.Interfaces;
using BusinessLogic.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using MyAttribute = Domain.Models.Attribute;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с атрибутами.
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        private readonly IAttributeServise _attributeService;

        /// Конструктор контроллера AttributesController.
        /// <param name="attributeService">Сервис для работы с атрибутами.</param>
        public AttributesController(IAttributeServise attributeService)
        {
            _attributeService = attributeService;
        }

        /// Получает список всех атрибутов.
        /// <returns>Список атрибутов.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var attributes = await _attributeService.GetAll();
            return Ok(attributes);
        }

        /// Получает атрибут по его идентификатору.
        /// <param name="id">Идентификатор атрибута.</param>
        /// <returns>Атрибут.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var attribute = await _attributeService.GetById(id);
            return Ok(attribute);
        }

        /// Добавляет новый атрибут.
        /// <param name="attribute">Модель атрибута для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(MyAttribute attribute)
        {
            await _attributeService.Create(attribute);
            return Ok();
        }

        /// Обновляет существующий атрибут.
        /// <param name="attribute">Модель атрибута для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(MyAttribute attribute)
        {
            await _attributeService.Update(attribute);
            return Ok();
        }

        /// Удаляет атрибут по его идентификатору.
        /// <param name="id">Идентификатор атрибута.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _attributeService.Delete(id);
            return Ok();
        }
    }
}