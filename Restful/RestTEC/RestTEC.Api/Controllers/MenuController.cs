using Microsoft.AspNetCore.Mvc;
using RestTEC.Api.Responses;
using RestTEC.Core.Entities;
using RestTEC.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestTEC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _menuRepository;
        public MenuController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetDishes()
        {
            var menu = await _menuRepository.GetDishes();
            var response = new ApiResponse<IEnumerable<Menu>>(menu);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDish(int id)
        {
            var dish = await _menuRepository.GetDish(id);
            var response = new ApiResponse<Menu>(dish);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Dish(Menu menu)
        {
            await _menuRepository.InsertDish(menu);
            var response = new ApiResponse<Menu>(menu);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Menu menu)
        {
            menu.Id = id;
            var result = await _menuRepository.UpdateMenu(menu);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _menuRepository.Delete(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
