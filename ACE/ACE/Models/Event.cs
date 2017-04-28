using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACE.Models
{
    public class Event
    {
        public int EventID { get; set; }

        [StringLength(50, MinimumLength=4)]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [StringLength(150)]
        [Display(Name = "Description")]
        public string EventDesc { get; set; }

        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "Country")]
        public string EventCountry { get; set; }

        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "City")]
        public string EventCity { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Event StartDate")]
        public DateTime EventStartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Event EndDate")]
        public DateTime EventEndDate { get; set; }

        [Range(1,5)]
        [Display(Name = "Total No. of Pit Stops")]
        public int EventTotalPitStops { get; set; }

        [Range(1, 10)]
        [Display(Name = "Total No. of Teams")]
        public int EventTotalTeams { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public virtual ICollection<PitStop> PitStops { get; set; }

    }
}