using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACE.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        public int EventID { get; set; }
        public virtual Event Event { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}