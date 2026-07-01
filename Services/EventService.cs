using System.Collections.Generic;
using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        public List<Event> Events { get; set; } = new List<Event>
        {
            new Event
            {
                Name="Microsoft Build",
                Location="Online",
                Date="June 2026",
                RegisteredUsers=50
            },

            new Event
            {
                Name="AI Workshop",
                Location="VIT",
                Date="July 2026",
                RegisteredUsers=120
            }
        };
    }
}
