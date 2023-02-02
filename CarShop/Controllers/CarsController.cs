using CarShop.Data.Interfaces;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarsController : Controller 
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iAllCategories)
        {
            _allCars = iAllCars;
            _allCategories = iAllCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with cars";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Cars";

            return View(obj);
        }
    }
}
