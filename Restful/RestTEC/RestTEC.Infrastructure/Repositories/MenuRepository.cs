using Microsoft.EntityFrameworkCore;
using RestTEC.Core.Entities;
using RestTEC.Core.Interfaces;
using RestTEC.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestTEC.Infrastructure.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly RestTECContext _context;

        public MenuRepository(RestTECContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Menu>> GetDishes()
        {
            var menu = await _context.Menus.ToListAsync();

            return menu;
        }

        public async Task InsertDish(Menu menu)
        {
            _context.Menus.Add(menu);
            await _context.SaveChangesAsync();

        }

    }
}
