using RestTEC.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestTEC.Core.Interfaces
{
    public interface IMenuRepository
    {
        Task<IEnumerable<Menu>> GetDishes();
        Task<Menu> GetDish(int id);
        Task InsertDish(Menu menu);
        Task<bool> UpdateMenu(Menu dish);
        Task<bool> Delete(int id);

    }
}
