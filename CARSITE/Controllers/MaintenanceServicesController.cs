using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с услугами технического обслуживания.
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceServicesController : ControllerBase
    {
        private readonly IMaintenanceServiceService _maintenanceServiceService;

        /// Конструктор контроллера MaintenanceServicesController.
        /// <param name="maintenanceServiceService">Сервис для работы с услугами технического обслуживания.</param>
        public MaintenanceServicesController(IMaintenanceServiceService maintenanceServiceService)
        {
            _maintenanceServiceService = maintenanceServiceService;
        }

        /// Получает список всех услуг технического обслуживания.
        /// <returns>Список услуг технического обслуживания.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var maintenanceServices = await _maintenanceServiceService.GetAll();
            return Ok(maintenanceServices);
        }

        /// Получает услугу технического обслуживания по ее идентификатору.
        /// <param name="id">Идентификатор услуги технического обслуживания.</param>
        /// <returns>Услуга технического обслуживания.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var maintenanceService = await _maintenanceServiceService.GetById(id);
            return Ok(maintenanceService);
        }

        /// Добавляет новую услугу технического обслуживания.
        /// <param name="maintenanceService">Модель услуги технического обслуживания для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(MaintenanceService maintenanceService)
        {
            await _maintenanceServiceService.Create(maintenanceService);
            return Ok();
        }

        /// Обновляет существующую услугу технического обслуживания.
        /// <param name="maintenanceService">Модель услуги технического обслуживания для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(MaintenanceService maintenanceService)
        {
            await _maintenanceServiceService.Update(maintenanceService);
            return Ok();
        }

        /// Удаляет услугу технического обслуживания по ее идентификатору.
        /// <param name="id">Идентификатор услуги технического обслуживания.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _maintenanceServiceService.Delete(id);
            return Ok();
        }
    }
}