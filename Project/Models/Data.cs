using Microsoft.EntityFrameworkCore;
using System;

namespace Project.Models
{
    public class CalendarContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public CalendarContext(DbContextOptions<CalendarContext> options):base(options) { }
    }

    public class Event
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Text { get; set; }
        public string? Color { get; set; }
    }

}
