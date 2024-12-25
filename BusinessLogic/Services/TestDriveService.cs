using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью TestDrife (тестовая поездка).
    /// Реализует интерфейс ITestDriveService.
    public class TestDriveService : ITestDriveService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public TestDriveService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех тестовых поездок.
        /// <returns>Список тестовых поездок.</returns>
        public async Task<List<TestDrife>> GetAll()
        {
            return await _repositoryWrapper.TestDrife.FindAll();
        }

        /// Получает тестовую поездку по её идентификатору.
        /// <param name="id">Идентификатор тестовой поездки.</param>
        /// <returns>Тестовая поездка.</returns>
        public async Task<TestDrife> GetById(int id)
        {
            var testDrife = await _repositoryWrapper.TestDrife
                .FindByCondition(x => x.TestDriveId == id);
            return testDrife.First();
        }

        /// Создаёт новую тестовую поездку.
        /// <param name="model">Модель тестовой поездки.</param>
        public async Task Create(TestDrife model)
        {
            await _repositoryWrapper.TestDrife.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о тестовой поездке.
        /// <param name="model">Модель тестовой поездки с обновлёнными данными.</param>
        public async Task Update(TestDrife model)
        {
            _repositoryWrapper.TestDrife.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет тестовую поездку по её идентификатору.
        /// <param name="id">Идентификатор тестовой поездки.</param>
        public async Task Delete(int id)
        {
            var testDrife = await _repositoryWrapper.TestDrife
                .FindByCondition(x => x.TestDriveId == id);

            _repositoryWrapper.TestDrife.Delete(testDrife.First());
            _repositoryWrapper.Save();
        }
    }
}