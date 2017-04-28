using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACE.Models
{
	public class Location
	{
        public int LocationID { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public string Time { get; set; }
        public string Pitstop { get; set; }
        public string Position { get; set; }
    }
}