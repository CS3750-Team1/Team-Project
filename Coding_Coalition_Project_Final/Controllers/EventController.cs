using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coding_Coalition_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly Coding_Coalition_ProjectContext _context;
        public EventController(Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        // GET api/events
        [HttpGet]
        public IEnumerable<WebAPIEvent> Get()
        {
            return _context.Calender
                .ToList()
                .Select(e => (WebAPIEvent)e);
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public WebAPIEvent Get(int id)
        {
            return (WebAPIEvent)_context
                .Calender
                .Find(id);
        }

        // POST api/events
        [HttpPost]
        public ObjectResult Post([FromForm] WebAPIEvent apiEvent)
        {
            var newEvent = (CalenderModel)apiEvent;

            _context.Calender.Add(newEvent);
            _context.SaveChanges();

            return Ok(new
            {
                tid = newEvent.ID,
                action = "inserted"
            });
        }

        // PUT api/events/5
        [HttpPut("{id}")]
        public ObjectResult Put(int id, [FromForm] WebAPIEvent apiEvent)
        {
            var updatedEvent = (CalenderModel)apiEvent;
            var dbEvent = _context.Calender.Find(id);
            dbEvent.Name = updatedEvent.Name;
            dbEvent.StartDate = updatedEvent.StartDate;
            dbEvent.EndDate = updatedEvent.EndDate;
            _context.SaveChanges();

            return Ok(new
            {
                action = "updated"
            });
        }

        // DELETE api/events/5
        [HttpDelete("{id}")]
        public ObjectResult DeleteEvent(int id)
        {
            var e = _context.Calender.Find(id);
            if (e != null)
            {
                _context.Calender.Remove(e);
                _context.SaveChanges();
            }

            return Ok(new
            {
                action = "deleted"
            });
        }


    }
}
