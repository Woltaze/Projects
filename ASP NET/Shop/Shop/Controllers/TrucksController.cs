using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class TrucksController : Controller
    {
        private readonly IAllTrucks _allTrucks;
        private readonly ITrucksCategory _allCategories;

        
        public TrucksController(IAllTrucks iAllTrucks, ITrucksCategory iTrucksCat)
        {
            _allTrucks = iAllTrucks;
            _allCategories = iTrucksCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с эвакуаторами";
            TrucksListViewModel obj = new TrucksListViewModel();
            obj.AllTrucks = _allTrucks.Trucks;
            obj.currCategory = "Эвакуаторы";
            return View(obj);
        }
    
    }
}
