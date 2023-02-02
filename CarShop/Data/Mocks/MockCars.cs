using CarShop.Data.Interfaces;
using CarShop.Data.Models;

namespace CarShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categotyCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful, fast and very quiet Tesla car",
                        img = "/img/tesla_model_s.webp",
                        price = 60000,
                        isFavourite = true,
                        available = false,
                        Category = _categotyCars.AllCategories.First()
                    },
                    new Car {
                        name = "Tesla Model 3",
                        shortDesc = "Fast and cheap car",
                        longDesc = "Beautiful and very quiet Tesla car",
                        img = "/img/tesla_model_3.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categotyCars.AllCategories.First()
                    },
                    new Car {
                        name = "Kia Niro EV",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful, fast and very quiet car",
                        img = "/img/kia_niro_ev.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categotyCars.AllCategories.First()
                    },
                    new Car {
                        name = "Jaguar I-Pace",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful and fast car",
                        img = "/img/jaguar+i-pace.webp",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categotyCars.AllCategories.First()
                    },
                    new Car {
                        name = "Toyota RAV4",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful, fast and very quiet car",
                        img = "/img/toyota_rav4.jpg",
                        price = 48000,
                        isFavourite = true,
                        available = true,
                        Category = _categotyCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mercedes s class",
                        shortDesc = "Premium car",
                        longDesc = "Beautiful and fast car",
                        img = "/img/mercedec_s_class.webp",
                        price = 65000,
                        isFavourite = true,
                        available = false,
                        Category = _categotyCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
