using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACE.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "Member Name")]
        public string MemberName { get; set; }
        public int TeamID { get; set; }
        [Phone]
        public string MemberContact { get; set; }
        [EmailAddress]
        public string MemberEmail { get; set; }
        public byte[] MemberPhoto { get; set; }
        public virtual Team Team { get; set; }
    }
}