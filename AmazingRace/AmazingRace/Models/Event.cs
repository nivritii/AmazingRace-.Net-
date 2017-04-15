using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public int TotalPitStops { get; set; }
        public int TotalTeams { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}