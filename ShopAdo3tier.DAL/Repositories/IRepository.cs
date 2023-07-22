using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAdo3tier.DAL.Repositories
{
    //объявляем public, потому что нужно получать к нему доступ из других сборок
    public interface IRepository<T> //делаем обобщённым. Чтобы его можно было использовать для работы с любым типом данных.
    {
        IEnumerable<T> GetAll(); //возвращает список всех объектов
        T Get(int id); //возвращает всю инф-цию об объекте по id
        void CreateOrUpdate(T entity); //создаёт новый объект или обновляет уже существующий в хранилище данных
        void Delete(T entity);
        void Save();
    }
}
