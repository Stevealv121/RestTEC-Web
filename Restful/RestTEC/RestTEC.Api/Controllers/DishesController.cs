using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public IActionResult GetDishes()
        {
            var dishes = new DishRepository().GetDishes();
            return Ok(dishes);
        }
    }
}
