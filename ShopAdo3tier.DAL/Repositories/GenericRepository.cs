using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAdo3tier.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class //ограничение (where T : class), ссылочный тип(или класс), а не структура(или int).
    {                           //Это общий репозиторий, то есть теперь можно быстро создавать репозитории.
        DbContext context;
        DbSet<T> set;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            set = this.context.Set<T>(); //создаём коллекцию всех объектов типа <T> в базе данных, связанной с DbContext. 
        }                                                       //Можно использовать для выполнения CRUD-операций

        public void CreateOrUpdate(T entity) => set.AddOrUpdate(entity);//`NotImplementedException` является предопределенным классом исключения 
                                                                                    //в .NET Framework. Указывает, что функциональность или метод еще не были реализованы.
        public void Delete(T entity) => set.Remove(entity);

        public T Get(int id) => set.Find(id);

        public IEnumerable<T> GetAll() => set;

        public void Save() => context.SaveChanges();
    }
}
