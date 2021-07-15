using RestTEC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestTEC.Core.Interfaces
{
    public interface IDishRepository
    {
        Task<IEnumerable<Dish>> GetDishes();
    }
}
