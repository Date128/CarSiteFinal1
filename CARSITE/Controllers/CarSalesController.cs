using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с продажами автомобилей.
    [Route("api/[controller]")]
    [ApiController]
    public class CarSalesController : ControllerBase
    {
        private readonly ICarSaleService _carSaleService;

        /// Конструктор контроллера CarSalesController.
        /// <param name="carSaleService">Сервис для работы с продажами автомобилей.</param>
        public CarSalesController(ICarSaleService carSaleService)
        {
            _carSaleService = carSaleService;
        }

        /// Получает список всех продаж автомобилей.
        /// <returns>Список продаж автомобилей.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var carSales = await _carSaleService.GetAll();
            return Ok(carSales);
        }

        /// Получает продажу автомобиля по ее идентификатору.
        /// <param name="id">Идентификатор продажи автомобиля.</param>
        /// <returns>Продажа автомобиля.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var carSale = await _carSaleService.GetById(id);
            return Ok(carSale);
        }

        /// Добавляет новую продажу автомобиля.
        /// <param name="carSale">Модель продажи автомобиля для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(CarSale carSale)
        {
            await _carSaleService.Create(carSale);
            return Ok();
        }

        /// Обновляет существующую продажу автомобиля.
        /// <param name="carSale">Модель продажи автомобиля для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(CarSale carSale)
        {
            await _carSaleService.Update(carSale);
            return Ok();
        }

        /// Удаляет продажу автомобиля по ее идентификатору.
        /// <param name="id">Идентификатор продажи автомобиля.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carSaleService.Delete(id);
            return Ok();
        }
    }
}