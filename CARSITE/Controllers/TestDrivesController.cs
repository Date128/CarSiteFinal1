using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с тест-драйвами.
    [Route("api/[controller]")]
    [ApiController]
    public class TestDrivesController : ControllerBase
    {
        private readonly ITestDriveService _testDriveService;

        /// Конструктор контроллера TestDrivesController.
        /// <param name="testDriveService">Сервис для работы с тест-драйвами.</param>
        public TestDrivesController(ITestDriveService testDriveService)
        {
            _testDriveService = testDriveService;
        }

        /// Получает список всех тест-драйвов.
        /// <returns>Список тест-драйвов.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var testDrives = await _testDriveService.GetAll();
            return Ok(testDrives);
        }

        /// Получает тест-драйв по его идентификатору.
        /// <param name="id">Идентификатор тест-драйва.</param>
        /// <returns>Тест-драйв.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var testDrive = await _testDriveService.GetById(id);
            return Ok(testDrive);
        }

        /// Добавляет новый тест-драйв.
        /// <param name="testDrive">Модель тест-драйва для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(TestDrife testDrive)
        {
            await _testDriveService.Create(testDrive);
            return Ok();
        }

        /// Обновляет существующий тест-драйв.
        /// <param name="testDrive">Модель тест-драйва для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(TestDrife testDrive)
        {
            await _testDriveService.Update(testDrive);
            return Ok();
        }

        /// Удаляет тест-драйв по его идентификатору.
        /// <param name="id">Идентификатор тест-драйва.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _testDriveService.Delete(id);
            return Ok();
        }
    }
}