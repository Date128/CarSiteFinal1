using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с изображениями автомобилей.
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private readonly ICarImageService _carImageService;

        /// Конструктор контроллера CarImagesController.
        /// <param name="carImageService">Сервис для работы с изображениями автомобилей.</param>
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        /// Получает список всех изображений автомобилей.
        /// <returns>Список изображений автомобилей.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var carImages = await _carImageService.GetAll();
            return Ok(carImages);
        }

        /// Получает изображение автомобиля по его идентификатору.
        /// <param name="id">Идентификатор изображения автомобиля.</param>
        /// <returns>Изображение автомобиля.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var carImage = await _carImageService.GetById(id);
            return Ok(carImage);
        }

        /// Добавляет новое изображение автомобиля.
        /// <param name="carImage">Модель изображения автомобиля для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(CarImage carImage)
        {
            await _carImageService.Create(carImage);
            return Ok();
        }

        /// Обновляет существующее изображение автомобиля.
        /// <param name="carImage">Модель изображения автомобиля для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(CarImage carImage)
        {
            await _carImageService.Update(carImage);
            return Ok();
        }

        /// Удаляет изображение автомобиля по его идентификатору.
        /// <param name="id">Идентификатор изображения автомобиля.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carImageService.Delete(id);
            return Ok();
        }
    }
}