using Domain.Interfaces;
using Domain.Models;
using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Tag (тег).
    /// Реализует интерфейс ITagService.
    public class TagService : ITagService
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public TagService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех тегов.
        /// <returns>Список тегов.</returns>
        public async Task<List<Tag>> GetAll()
        {
            return await _repositoryWrapper.Tag.FindAll();
        }

        /// Получает тег по его идентификатору.
        /// <param name="id">Идентификатор тега.</param>
        /// <returns>Тег.</returns>
        public async Task<Tag> GetById(int id)
        {
            var tag = await _repositoryWrapper.Tag
                .FindByCondition(x => x.TagId == id);
            return tag.First();
        }

        /// Создаёт новый тег.
        /// <param name="model">Модель тега.</param>
        public async Task Create(Tag model)
        {
            await _repositoryWrapper.Tag.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию о теге.
        /// <param name="model">Модель тега с обновлёнными данными.</param>
        public async Task Update(Tag model)
        {
            _repositoryWrapper.Tag.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет тег по его идентификатору.
        /// <param name="id">Идентификатор тега.</param>
        public async Task Delete(int id)
        {
            var tag = await _repositoryWrapper.Tag
                .FindByCondition(x => x.TagId == id);

            _repositoryWrapper.Tag.Delete(tag.First());
            _repositoryWrapper.Save();
        }
    }
}