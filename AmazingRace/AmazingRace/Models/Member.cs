using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int TeamID { get; set; }
        public int ContactNo { get; set; }
        public string email { get; set; }

        public virtual Team Team { get; set; }
    }
}