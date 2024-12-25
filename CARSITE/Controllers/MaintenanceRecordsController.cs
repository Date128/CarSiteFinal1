using Microsoft.AspNetCore.Mvc;

namespace CARSITE.Controllers
{
    /// Контроллер для работы с записями о техническом обслуживании.
    public class MaintenanceRecordsController : Controller
    {
        /// Возвращает представление для страницы Index.
        /// <returns>Представление Index.</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}