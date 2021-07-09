using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestTECService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            var Orders = new List<Order>();
            for (int i = 1; i <= 3; i++)
            {
                var order = new Order
                {
                    Id = i,
                    AssignTo = "unassigned",
                    EstimatedTime = 12 / i

                };
                Orders.Add(order);
            }
            return Orders;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            var order = new Order
            {
                Id = id,
                AssignTo = "unassigned",
                EstimatedTime = 12 / id

            };
            return order;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
