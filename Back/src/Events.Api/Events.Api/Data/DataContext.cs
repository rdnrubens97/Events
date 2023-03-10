using Events.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Events.Api.Data
{
    public class EventsContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
        }
    }
}
