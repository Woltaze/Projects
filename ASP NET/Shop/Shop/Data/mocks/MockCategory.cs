using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ITrucksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Дизельные эвакуаторы", desc = "Транспорт на дизельном топливе"},
                    new Category {categoryName = "Бензиновые эвакуаторы", desc = "Транспорт на бензине" }
                };


            }    
                
        }       
    }
}
