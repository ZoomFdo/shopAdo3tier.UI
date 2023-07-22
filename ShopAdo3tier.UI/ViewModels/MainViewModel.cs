using Shop3tier.BLL.DTO;
using Shop3tier.BLL.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAdo3tier.UI.ViewModels
{
    internal class MainViewModel
    {
        GoodService goodService;


        public ObservableCollection<GoodDTO> Goods { get; set; }
        public MainViewModel()
        {
            goodService = new GoodService();
            Goods = new ObservableCollection<GoodDTO>(goodService.GetAll());
        }




        //--|--//
    }
}
