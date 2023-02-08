using Events.Api.Data;
using Events.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Events.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly EventsContext _context;

        public EventController(EventsContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }

        [HttpGet("{id}")]
        public Event GetById(int id)
        {
            return _context.Events.FirstOrDefault(x => x.EventId == id);
        }

        [HttpPost]
        public IEnumerable<Event> Post()
        {
            return _context.Events;
        }

        [HttpPut]
        public IEnumerable<Event> Put()
        {
            return _context.Events;
        }

        [HttpDelete]
        public IEnumerable<Event> Delete()
        {
            return _context.Events;
        }







    }
}