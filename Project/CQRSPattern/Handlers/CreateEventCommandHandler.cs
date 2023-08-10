using Project.Models;

namespace Project.CQRSPattern.Handlers
{
    public class CreateEventCommandHandler
    {
        private readonly CalendarContext _context;

        public CreateEventCommandHandler(CalendarContext context)
        {
            _context = context;
        }

        public void Handle(Event command)
        {
            _context.Events.Add(new Event
            {
                Start = command.Start,
                End = command.End,
                Text = command.Text,
                Color = command.Color
            });
            _context.SaveChanges();
        }
    }
}
