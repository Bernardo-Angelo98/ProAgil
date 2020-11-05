using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.Data;
using ProAgil.Models;

namespace ProAgil.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Event>> Get()
        {
            return new Event[] {
                new Event() {
                    EventId = 1,
                    Theme = "Angular and .Net Core",
                    Local = "Portugal",
                    Lot = " 1º Lot",
                    QtPeople = 250,
                    Date = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Event() {
                    EventId = 2,
                    Theme = "Angular and News Applications",
                    Local = "Portugal",
                    Lot = " 2º Lot",
                    QtPeople = 350,
                    Date = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }
            };
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            return new Event[] {
                new Event() {
                    EventId = 1,
                    Theme = "Angular and .Net Core",
                    Local = "Portugal",
                    Lot = " 1º Lot",
                    QtPeople = 250,
                    Date = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Event() {
                    EventId = 2,
                    Theme = "Angular and News Applications",
                    Local = "Portugal",
                    Lot = " 2º Lot",
                    QtPeople = 350,
                    Date = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }
            }.FirstOrDefault(x => x.EventId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
