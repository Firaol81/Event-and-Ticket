﻿using System.Collections.Generic;

namespace Event_and_Ticket.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }

        // Navigation property for Events
        public ICollection<Event> Events { get; set; }
    }
}
