//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheAmazingRace
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Nullable<System.DateTime> EventStart { get; set; }
        public Nullable<System.DateTime> EventEnd { get; set; }
        public Nullable<decimal> TotalPitStops { get; set; }
    }
}
