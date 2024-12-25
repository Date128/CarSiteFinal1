using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с уведомлениями.
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        /// Конструктор контроллера NotificationsController.
        /// <param name="notificationService">Сервис для работы с уведомлениями.</param>
        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        /// Получает список всех уведомлений.
        /// <returns>Список уведомлений.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var notifications = await _notificationService.GetAll();
            return Ok(notifications);
        }

        /// Получает уведомление по его идентификатору.
        /// <param name="id">Идентификатор уведомления.</param>
        /// <returns>Уведомление.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var notification = await _notificationService.GetById(id);
            return Ok(notification);
        }

        /// Добавляет новое уведомление.
        /// <param name="notification">Модель уведомления для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Notification notification)
        {
            await _notificationService.Create(notification);
            return Ok();
        }

        /// Обновляет существующее уведомление.
        /// <param name="notification">Модель уведомления для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Notification notification)
        {
            await _notificationService.Update(notification);
            return Ok();
        }

        /// Удаляет уведомление по его идентификатору.
        /// <param name="id">Идентификатор уведомления.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _notificationService.Delete(id);
            return Ok();
        }
    }
}