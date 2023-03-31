using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockTrucks : IAllTrucks
    {

        private readonly ITrucksCategory _categoryTrucks = new MockCategory();

        public IEnumerable<Truck> Trucks {


            get
            {
                return new List<Truck> {
                    new Truck {
                        name = "Hyundai HD78",
                        shortDesc="Hyundai HD78 эвакуатор-автовоз",
                        longDesc = "Машина в практически как новая. Удлиненная база. Все вписано в ПТС. Автомобиль использовался для перевозки новых автомобилей Мерседес-Бенц РУС.",
                        img = "/img/Hyundai.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryTrucks.AllCategories.First()
                    },
                    new Truck {
                        name = "Hino 300 (Dutro)",
                        shortDesc="объем двигателя 4 л",
                        longDesc = "технически в отличном состоянии",
                        img = "/img/Hino.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryTrucks.AllCategories.Last()
                    },
                    new Truck {
                        name = "ГАЗ ГАЗон Next",
                        shortDesc="Максимальная комплектация",
                        longDesc = " Платформа 6,40х2,50.Алюминевый бак. Съемные борта Зад. аутр., гидрофорс. усиленные",
                        img = "/img/Next.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryTrucks.AllCategories.Last()
                    },
                    new Truck {
                        name = "Ford Transit",
                        shortDesc="2013-го года",
                        longDesc = "Автомобиль в отличном техническом состоянии",
                        img = "/img/Ford.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryTrucks.AllCategories.Last()
                    },
                    new Truck {
                        name = "Volvo FES",
                        shortDesc="",
                        longDesc = "",
                        img = "/img/Volvo.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryTrucks.AllCategories.First()
                    },
                };

           }
      }
        public IEnumerable<Truck> getFavTrucks { get; set; }

        public Truck getObjectTruck(int truckId)
        {
            throw new NotImplementedException();
        }
    }
  
}
