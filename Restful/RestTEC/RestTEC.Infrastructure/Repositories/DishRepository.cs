using RestTEC.Core.Entities;
using RestTEC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestTEC.Infrastructure.Repositories
{
    public class DishRepository : IDishRepository
    {
        public async Task<IEnumerable<Dish>> GetDishes()
        {
            var dishes = Enumerable.Range(1, 10).Select(x => new Dish
            {
                DishId = x,
                Name = $"Name {x}",
                Description = $"Description {x}",
                Price = x * 2,
                Calories = x * 3,
                Type = $"Type {x}"
            });

            await Task.Delay(10);

            return dishes;
        }

    }
}
