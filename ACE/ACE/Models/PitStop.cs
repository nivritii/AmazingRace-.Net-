using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACE.Models
{
    public class PitStop
    {
        public int PitStopID { get; set; }
        public int EventID { get; set; }
        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "Pit Stop Name")]
        public string PitStopName { get; set; }
        [Range(1,5)]
        public int PitStopOrder { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Pit Stop Location")]
        public string PitStopLocation { get; set; }
        public int StaffID { get; set; }
        public virtual Event Event { get; set; }
        public virtual Staff Staff { get; set; }
    }
}