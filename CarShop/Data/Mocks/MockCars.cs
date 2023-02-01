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
                        img = "https://avatars.mds.yandex.net/get-verba/1540742/2a0000017761d1c8de5ba80a8148f180432f/cattouchret",
                        price = 60000,
                        isFavourite = true,
                        available = false,
                        Category = _categotyCars.AllCategories.First()
                    },
                    new Car {
                        name = "Tesla Model 3",
                        shortDesc = "Fast and cheap car",
                        longDesc = "Beautiful and very quiet Tesla car",
                        img = "https://assets-global.website-files.com/60ce1b7dd21cd517bb39ff20/6153cdf8aec0a73b65af24c0_tesla-model-3.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categotyCars.AllCategories.First()
                    },
                    new Car {
                        name = "Kia Niro EV",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful, fast and very quiet car",
                        img = "https://elektrowoz.pl/wp-content/uploads/2022/06/Kia-Niro-EV.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categotyCars.AllCategories.First()
                    },
                    new Car {
                        name = "Jaguar I-Pace",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful and fast car",
                        img = "https://i.wpimg.pl/1920x1280/m.autokult.pl/jaguar-i-pace-ev320-se-4-b98951c.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categotyCars.AllCategories.First()
                    },
                    new Car {
                        name = "Toyota RAV4",
                        shortDesc = "Fast car",
                        longDesc = "Beautiful, fast and very quiet car",
                        img = "https://images.caradisiac.com/logos-ref/modele/modele--toyota-rav-4-4e-generation/S0-modele--toyota-rav-4-4e-generation.jpg",
                        price = 48000,
                        isFavourite = true,
                        available = true,
                        Category = _categotyCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mersedes s class",
                        shortDesc = "Premium car",
                        longDesc = "Beautiful and fast car",
                        img = "https://imgd.aeplcdn.com/1200x900/n/cw/ec/48067/s-class-exterior-right-front-three-quarter-3.jpeg?q=75",
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
