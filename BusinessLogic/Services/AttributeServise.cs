using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using MyAttribute = Domain.Models.Attribute;

namespace BusinessLogic.Services
{
    /// Сервис для работы с сущностью Attribute (атрибут).
    /// Реализует интерфейс IAttributeServise.
    public class AttributeServise : IAttributeServise
    {
        private IRepositoryWrapper _repositoryWrapper;

        /// Конструктор сервиса.
        /// <param name="repositoryWrapper">Обёртка репозиториев для доступа к данным.</param>
        public AttributeServise(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /// Получает список всех атрибутов.
        /// <returns>Список атрибутов.</returns>
        public async Task<List<MyAttribute>> GetAll()
        {
            return await _repositoryWrapper.Attribute.FindAll();
        }

        /// Получает атрибут по его идентификатору.
        /// <param name="id">Идентификатор атрибута.</param>
        /// <returns>Атрибут.</returns>
        public async Task<MyAttribute> GetById(int id)
        {
            var attribute = await _repositoryWrapper.Attribute
                .FindByCondition(x => x.AttributeId == id);
            return attribute.First();
        }

        /// Создаёт новый атрибут.
        /// <param name="model">Модель атрибута.</param>
        public async Task Create(MyAttribute model)
        {
            await _repositoryWrapper.Attribute.Create(model);
            _repositoryWrapper.Save();
        }

        /// Обновляет информацию об атрибуте.
        /// <param name="model">Модель атрибута с обновлёнными данными.</param>
        public async Task Update(MyAttribute model)
        {
            _repositoryWrapper.Attribute.Update(model);
            _repositoryWrapper.Save();
        }

        /// Удаляет атрибут по его идентификатору.
        /// <param name="id">Идентификатор атрибута.</param>
        public async Task Delete(int id)
        {
            var attribute = await _repositoryWrapper.Attribute
                .FindByCondition(x => x.AttributeId == id);

            _repositoryWrapper.Attribute.Delete(attribute.First());
            _repositoryWrapper.Save();
        }
    }
}