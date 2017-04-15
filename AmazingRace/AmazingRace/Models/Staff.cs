using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public Boolean TeasStaff { get; set; }
    }
}