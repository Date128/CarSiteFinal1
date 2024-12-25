using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// Интерфейс для работы с тест-драйвами.
    public interface ITestDriveService
    {
        /// Получает список всех тест-драйвов.
        /// <returns>Список тест-драйвов.</returns>
        Task<List<TestDrife>> GetAll();

        /// Получает тест-драйв по его идентификатору.
        /// <param name="id">Идентификатор тест-драйва.</param>
        /// <returns>Тест-драйв.</returns>
        Task<TestDrife> GetById(int id);

        /// Создает новый тест-драйв.
        /// <param name="model">Модель тест-драйва для создания.</param>
        Task Create(TestDrife model);

        /// Обновляет существующий тест-драйв.
        /// <param name="model">Модель тест-драйва для обновления.</param>
        Task Update(TestDrife model);

        /// Удаляет тест-драйв по его идентификатору.
        /// <param name="id">Идентификатор тест-драйва.</param>
        Task Delete(int id);
    }
}