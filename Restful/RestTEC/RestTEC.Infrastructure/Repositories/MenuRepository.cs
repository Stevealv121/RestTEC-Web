using Microsoft.EntityFrameworkCore;
using RestTEC.Core.Entities;
using RestTEC.Core.Interfaces;
using RestTEC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
