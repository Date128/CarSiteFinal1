using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    /// Контроллер для работы с профилями пользователей.
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilesController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;

        /// Конструктор контроллера UserProfilesController.
        /// <param name="userProfileService">Сервис для работы с профилями пользователей.</param>
        public UserProfilesController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        /// Получает список всех профилей пользователей.
        /// <returns>Список профилей пользователей.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var userProfiles = await _userProfileService.GetAll();
            return Ok(userProfiles);
        }

        /// Получает профиль пользователя по его идентификатору.
        /// <param name="id">Идентификатор профиля пользователя.</param>
        /// <returns>Профиль пользователя.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var userProfile = await _userProfileService.GetById(id);
            return Ok(userProfile);
        }

        /// Добавляет новый профиль пользователя.
        /// <param name="userProfile">Модель профиля пользователя для добавления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(UserProfile userProfile)
        {
            await _userProfileService.Create(userProfile);
            return Ok();
        }

        /// Обновляет существующий профиль пользователя.
        /// <param name="userProfile">Модель профиля пользователя для обновления.</param>
        /// <returns>Результат операции.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(UserProfile userProfile)
        {
            await _userProfileService.Update(userProfile);
            return Ok();
        }

        /// Удаляет профиль пользователя по его идентификатору.
        /// <param name="id">Идентификатор профиля пользователя.</param>
        /// <returns>Результат операции.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userProfileService.Delete(id);
            return Ok();
        }
    }
}