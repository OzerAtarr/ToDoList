using Microsoft.EntityFrameworkCore;
using Project.CQRSPattern.Results;
using Project.Models;

namespace Project.CQRSPattern.Handlers
{
    public class GetEventQueryHandler
    {
        private readonly CalendarContext _context;

        public GetEventQueryHandler(CalendarContext context)
        {
            _context = context;
        }

        public IQueryable<Event> Handle(DateTime start, DateTime end)
        {
            var values = _context.Events.Where(e => !((e.End <= start) || (e.Start >= end)));
            return values;
        }
    }
}
