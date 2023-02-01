using CarShop.Data.Interfaces;
using CarShop.Data.Models;

namespace CarShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Electric cars", desc = "Car with electric motor"},
                    new Category { categoryName = "Cars", desc = "Cars with an internal combustion engine" }
                };
            }
        }
    }
}
