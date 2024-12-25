using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с автомобилями.
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarServices _carService;

        /// Конструктор контроллера CarsController.
        /// <param name="carService">Сервис для работы с автомобилями.</param>
        public CarsController(ICarServices carService)
        {
            _carService = carService;
        }

        /// Получает список всех автомобилей.
        /// <returns>Список автомобилей.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cars = await _carService.GetAll();
            return Ok(cars);
        }

        /// Получает автомобиль по его идентификатору.
        /// <param name="id">Идентификатор автомобиля.</param>
        /// <returns>Автомобиль.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var car = await _carService.GetById(id);
            return Ok(car);
        }

        /// Добавляет новый автомобиль.
        /// <param name="car">Модель автомобиля для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Car car)
        {
            await _carService.Create(car);
            return Ok();
        }

        /// Обновляет существующий автомобиль.
        /// <param name="car">Модель автомобиля для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Car car)
        {
            await _carService.Update(car);
            return Ok();
        }

        /// Удаляет автомобиль по его идентификатору.
        /// <param name="id">Идентификатор автомобиля.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carService.Delete(id);
            return Ok();
        }
    }
}