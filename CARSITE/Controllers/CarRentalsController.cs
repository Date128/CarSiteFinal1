using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с арендой автомобилей.
    [Route("api/[controller]")]
    [ApiController]
    public class CarRentalsController : ControllerBase
    {
        private readonly ICarRentalService _carRentalService;

        /// Конструктор контроллера CarRentalsController.
        /// <param name="carRentalService">Сервис для работы с арендой автомобилей.</param>
        public CarRentalsController(ICarRentalService carRentalService)
        {
            _carRentalService = carRentalService;
        }

        /// Получает список всех записей об аренде автомобилей.
        /// <returns>Список записей об аренде автомобилей.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var carRentals = await _carRentalService.GetAll();
            return Ok(carRentals);
        }

        /// Получает запись об аренде автомобиля по ее идентификатору.
        /// <param name="id">Идентификатор записи об аренде автомобиля.</param>
        /// <returns>Запись об аренде автомобиля.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var carRental = await _carRentalService.GetById(id);
            return Ok(carRental);
        }

        /// Добавляет новую запись об аренде автомобиля.
        /// <param name="carRental">Модель записи об аренде автомобиля для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(CarRental carRental)
        {
            await _carRentalService.Create(carRental);
            return Ok();
        }

        /// Обновляет существующую запись об аренде автомобиля.
        /// <param name="carRental">Модель записи об аренде автомобиля для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(CarRental carRental)
        {
            await _carRentalService.Update(carRental);
            return Ok();
        }

        /// Удаляет запись об аренде автомобиля по ее идентификатору.
        /// <param name="id">Идентификатор записи об аренде автомобиля.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carRentalService.Delete(id);
            return Ok();
        }
    }
}