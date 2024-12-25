using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с сервисными центрами.
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCentersController : ControllerBase
    {
        private readonly IServiceCenterService _serviceCenterService;

        /// Конструктор контроллера ServiceCentersController.
        /// <param name="serviceCenterService">Сервис для работы с сервисными центрами.</param>
        public ServiceCentersController(IServiceCenterService serviceCenterService)
        {
            _serviceCenterService = serviceCenterService;
        }

        /// Получает список всех сервисных центров.
        /// <returns>Список сервисных центров.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var serviceCenters = await _serviceCenterService.GetAll();
            return Ok(serviceCenters);
        }

        /// Получает сервисный центр по его идентификатору.
        /// <param name="id">Идентификатор сервисного центра.</param>
        /// <returns>Сервисный центр.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var serviceCenter = await _serviceCenterService.GetById(id);
            return Ok(serviceCenter);
        }

        /// Добавляет новый сервисный центр.
        /// <param name="serviceCenter">Модель сервисного центра для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(ServiceCenter serviceCenter)
        {
            await _serviceCenterService.Create(serviceCenter);
            return Ok();
        }

        /// Обновляет существующий сервисный центр.
        /// <param name="serviceCenter">Модель сервисного центра для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(ServiceCenter serviceCenter)
        {
            await _serviceCenterService.Update(serviceCenter);
            return Ok();
        }

        /// Удаляет сервисный центр по его идентификатору.
        /// <param name="id">Идентификатор сервисного центра.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _serviceCenterService.Delete(id);
            return Ok();
        }
    }
}