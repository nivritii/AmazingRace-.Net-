using ACE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACE.ViewModels
{
    public class EventIndexData
    {
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Member> Members { get; set; }
        public IEnumerable<PitStop> PitStops { get; set; }
        public IEnumerable<Staff> Staffs { get; set; }
    }
}