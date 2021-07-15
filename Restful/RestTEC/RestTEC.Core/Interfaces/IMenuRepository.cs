using RestTEC.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestTEC.Core.Interfaces
{
    public interface IMenuRepository
    {
        Task<IEnumerable<Menu>> GetDishes();
    }
}
