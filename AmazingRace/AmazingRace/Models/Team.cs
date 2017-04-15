using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int EventID { get; set; }
       // public int StaffID { get; set; }

        //public virtual Member Member { get; set; }
        public virtual Event Event { get; set; }
        //public virtual Staff Staff { get; set; }

        public virtual ICollection<Member> Members { get; set; }

    }
}