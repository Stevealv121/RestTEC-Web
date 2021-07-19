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

        public async Task<Menu> GetDish(int id)
        {
            var dish = await _context.Menus.FirstOrDefaultAsync(x => x.Id == id);
            return dish;

        }

        public async Task InsertDish(Menu menu)
        {
            _context.Menus.Add(menu);
            await _context.SaveChangesAsync();

        }

        public async Task<bool> UpdateMenu(Menu dish)
        {
            var currentDish = await GetDish(dish.Id);
            currentDish.Name = dish.Name;
            currentDish.Description = dish.Description;
            currentDish.Price = dish.Price;
            currentDish.Calories = dish.Calories;
            currentDish.Type = dish.Type;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var currentDish = await GetDish(id);
            _context.Menus.Remove(currentDish);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

    }
}
