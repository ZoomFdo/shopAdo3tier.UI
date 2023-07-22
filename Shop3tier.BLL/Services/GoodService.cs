using Shop3tier.BLL.DTO;
using ShopAdo3tier.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop3tier.BLL.Services
{
    public class GoodService // Сервис работает с DTO-объектами
    {
        GoodRepository repo = new GoodRepository(); //Репозиторий работает с контекстом Good

        public IEnumerable<GoodDTO> GetAll()
        {
            return repo.GetAll().Select(good => new GoodDTO //Преобразование коллекции Good-объектов в коллекцию GoodDTO-объектов
            {
                GoodId = good.GoodId,
                GoodName = good.GoodName,
                Price = good.Price,
                GoodCount = good.GoodCount,
                CategoryId = good.CategoryId,
                ManufacturerId = good.ManufacturerId,
                CategoryName = good.Category?.CategoryName,             //[Category?.] - проверка - категори, если он есть 
                ManufacturerName = good.Manufacturer?.ManufacturerName  
            });
        }
    }
}
