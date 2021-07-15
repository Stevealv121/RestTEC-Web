using Microsoft.AspNetCore.Mvc;
using RestTEC.Core.Interfaces;
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
            return Ok(menu);
        }
    }
}
