using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с записями о техническом обслуживании.
    [Route("api/[controller]")]
    [ApiController]
    public class TechnicalMaintenanceController : ControllerBase
    {
        private readonly ITechnicalMaintenanceService _technicalMaintenanceService;

        /// Конструктор контроллера TechnicalMaintenanceController.
        /// <param name="technicalMaintenanceService">Сервис для работы с записями о техническом обслуживании.</param>
        public TechnicalMaintenanceController(ITechnicalMaintenanceService technicalMaintenanceService)
        {
            _technicalMaintenanceService = technicalMaintenanceService;
        }

        /// Получает список всех записей о техническом обслуживании.
        /// <returns>Список записей о техническом обслуживании.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var technicalMaintenances = await _technicalMaintenanceService.GetAll();
            return Ok(technicalMaintenances);
        }

        /// Получает запись о техническом обслуживании по ее идентификатору.
        /// <param name="id">Идентификатор записи о техническом обслуживании.</param>
        /// <returns>Запись о техническом обслуживании.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var technicalMaintenance = await _technicalMaintenanceService.GetById(id);
            return Ok(technicalMaintenance);
        }

        /// Добавляет новую запись о техническом обслуживании.
        /// <param name="technicalMaintenance">Модель записи о техническом обслуживании для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(TechnicalMaintenance technicalMaintenance)
        {
            await _technicalMaintenanceService.Create(technicalMaintenance);
            return Ok();
        }

        /// Обновляет существующую запись о техническом обслуживании.
        /// <param name="technicalMaintenance">Модель записи о техническом обслуживании для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(TechnicalMaintenance technicalMaintenance)
        {
            await _technicalMaintenanceService.Update(technicalMaintenance);
            return Ok();
        }

        /// Удаляет запись о техническом обслуживании по ее идентификатору.
        /// <param name="id">Идентификатор записи о техническом обслуживании.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _technicalMaintenanceService.Delete(id);
            return Ok();
        }
    }
}