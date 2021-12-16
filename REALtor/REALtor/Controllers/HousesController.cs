using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REALtor.Data.Interfaces;
using REALtor.ViewModels;

namespace REALtor.Controllers
{
    public class HousesController: Controller
    {
        private readonly IAllHouses _allHouses;
        public HousesController(IAllHouses iAllHouses)
        {
            _allHouses = iAllHouses;
        }
        public ViewResult ListAllHouses()
        {
            ViewBag.Title = "Страница с недвижимостью";
            HousesListViewModel houses = new HousesListViewModel();
            houses.allHouses = _allHouses.Houses;
            return View(houses);
        }
        public ViewResult Main()
        {
            return View();
        }
    }
}
