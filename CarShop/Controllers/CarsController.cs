using CarShop.Data.Interfaces;
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
            ViewBag.Category = "Some New";
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
