using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestTEC.Core.Interfaces;
using RestTEC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestTEC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishRepository _dishRepository;
        public DishesController(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetDishes()
        {
            var dishes = await _dishRepository.GetDishes();
            return Ok(dishes);
        }
    }
}
