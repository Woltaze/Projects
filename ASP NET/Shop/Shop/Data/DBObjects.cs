using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Truck.Any())
            {
                content.AddRange(
                    new Truck
                    {
                        name = "Hyundai HD78",
                        shortDesc = "Hyundai HD78 эвакуатор-автовоз",
                        longDesc = "Машина в практически как новая. Удлиненная база. Все вписано в ПТС. Автомобиль использовался для перевозки новых автомобилей Мерседес-Бенц РУС.",
                        img = "/img/Hyundai.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Дизельные эвакуаторы"]
                    },
                    new Truck
                    {
                        name = "Hino 300 (Dutro)",
                        shortDesc = "объем двигателя 4 л",
                        longDesc = "технически в отличном состоянии",
                        img = "/img/Hino.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Бензиновые эвакуаторы"]
                    },
                    new Truck
                    {
                        name = "ГАЗ ГАЗон Next",
                        shortDesc = "Максимальная комплектация",
                        longDesc = " Платформа 6,40х2,50.Алюминевый бак. Съемные борта Зад. аутр., гидрофорс. усиленные",
                        img = "/img/Next.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Бензиновые эвакуаторы"]
                    },
                    new Truck
                    {
                        name = "Ford Transit",
                        shortDesc = "2013-го года",
                        longDesc = "Автомобиль в отличном техническом состоянии",
                        img = "/img/Ford.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Дизельные эвакуаторы"]
                    },
                    new Truck
                    {
                        name = "Volvo FES",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Volvo.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Бензиновые эвакуаторы"]
                    }
                    );
            }
        }


        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                          new Category {categoryName = "Дизельные эвакуаторы", desc = "Транспорт на дизельном топливе"},
                          new Category {categoryName = "Бензиновые эвакуаторы", desc = "Транспорт на бензине" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }

        }
    
    }
}
