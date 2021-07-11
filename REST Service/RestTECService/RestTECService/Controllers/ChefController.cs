using Microsoft.AspNetCore.Mvc;
using RestTECService.Data;
using RestTECService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestTECService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefController : ControllerBase
    {
        //SQLite
        public SQLite sqlite = new SQLite();


        // GET: api/<ChefController>
        [HttpGet]
        public IEnumerable<Chef> Get()
        {
            sqlite.connection = new SQLiteConnection(@"Data Source=C:\Users\Steve\Projects\Practice\RestTEC\Web Service\RestTEC-Web\Database\RestTEC.db");
            sqlite.connection.Open();

            sqlite.cmd = new SQLiteCommand(sqlite.connection)
            {
                CommandText = "select * from Chef"
            };
            sqlite.reader = sqlite.cmd.ExecuteReader();

            var chefs = new List<Chef>();

            while (sqlite.reader.Read())
            {
                var name = sqlite.reader.GetString(0);
                var email = sqlite.reader.GetString(1);
                var password = sqlite.reader.GetString(2);

                Chef chef = new Chef()
                {
                    name = name,
                    email = email,
                    password = password
                };

                chefs.Add(chef);
            }

            sqlite.reader.Close();

            return chefs;
        }

        // GET api/<ChefController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ChefController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChefController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChefController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
