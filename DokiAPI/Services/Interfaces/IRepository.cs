using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DokiAPI.Services.Interfaces
{
    public interface IRepository<TModel> where TModel: class
    {
        IEnumerable<TModel> GetAll(); // получение всех объектов
        TModel Get(int id); // получение одного объекта по id
        void Create(TModel item); // создание объекта
        void Update(TModel item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }
}
