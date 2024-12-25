using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с атрибутами автомобилей.
    [Route("api/[controller]")]
    [ApiController]
    public class CarAttributesController : ControllerBase
    {
        private readonly ICarAttributeService _carAttributeService;

        /// Конструктор контроллера CarAttributesController.
        /// <param name="carAttributeService">Сервис для работы с атрибутами автомобилей.</param>
        public CarAttributesController(ICarAttributeService carAttributeService)
        {
            _carAttributeService = carAttributeService;
        }

        /// Получает список всех атрибутов автомобилей.
        /// <returns>Список атрибутов автомобилей.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var carAttributes = await _carAttributeService.GetAll();
            return Ok(carAttributes);
        }

        /// Получает атрибут автомобиля по идентификаторам автомобиля и атрибута.
        /// <param name="carId">Идентификатор автомобиля.</param>
        /// <param name="attributeId">Идентификатор атрибута.</param>
        /// <returns>Атрибут автомобиля.</returns>
        [HttpGet("{carId}/{attributeId}")]
        public async Task<IActionResult> GetById(int carId, int attributeId)
        {
            var carAttribute = await _carAttributeService.GetById(carId, attributeId);
            return Ok(carAttribute);
        }

        /// Добавляет новый атрибут автомобиля.
        /// <param name="carAttribute">Модель атрибута автомобиля для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(CarAttribute carAttribute)
        {
            await _carAttributeService.Create(carAttribute);
            return Ok();
        }

        /// Обновляет существующий атрибут автомобиля.
        /// <param name="carAttribute">Модель атрибута автомобиля для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(CarAttribute carAttribute)
        {
            await _carAttributeService.Update(carAttribute);
            return Ok();
        }

        /// Удаляет атрибут автомобиля по идентификаторам автомобиля и атрибута.
        /// <param name="carId">Идентификатор автомобиля.</param>
        /// <param name="attributeId">Идентификатор атрибута.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{carId}/{attributeId}")]
        public async Task<IActionResult> Delete(int carId, int attributeId)
        {
            await _carAttributeService.Delete(carId, attributeId);
            return Ok();
        }
    }
}