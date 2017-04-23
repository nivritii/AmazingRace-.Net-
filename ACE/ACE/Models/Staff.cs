using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACE.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        [StringLength(8, MinimumLength = 3)]
        [Display(Name = "Staff Code")]
        public string StaffCode { get; set; }
        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "Staff Name")]
        public string StaffName { get; set; }
        public Boolean TeamStaff { get; set; }
        public virtual ICollection<PitStop> PitStops { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}