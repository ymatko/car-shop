using CarShop.Data.Models;

namespace CarShop.Data
{
    public class DBobjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Category.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful, fast and very quiet Tesla car",
                        img = "/img/tesla_model_s.png",
                        price = 60000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Electric cars"]
                    },
                    new Car
                    {
                        name = "Tesla Model 3",
                        shortDesc = "Fast and cheap car",
                        longDesc = "Beautiful and very quiet Tesla car",
                        img = "/img/tesla_model_3.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electric cars"]
                    },
                    new Car
                    {
                        name = "Kia Niro EV",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful, fast and very quiet car",
                        img = "/img/kia_niro_ev.png",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electric cars"]
                    },
                    new Car
                    {
                        name = "Jaguar I-Pace",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful and fast car",
                        img = "/img/jaguar_i-pace.png",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electric cars"]
                    },
                    new Car
                    {
                        name = "Toyota RAV4",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful, fast and very quiet car",
                        img = "/img/toyota_rav4.png",
                        price = 48000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Cars"]
                    },
                    new Car
                    {
                        name = "Mercedes s class",
                        shortDesc = "Premium car",
                        longDesc = "Beautiful and fast car",
                        img = "/img/mercedes_s_class.png",
                        price = 65000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Cars"]
                    }
                 );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Electric cars", desc = "Car with electric motor"},
                        new Category { categoryName = "Cars", desc = "Cars with an internal combustion engine" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category c in list)
                    {
                        category.Add(c.categoryName, c);
                    }
                }
                return category;
            }
        }
    }
}
