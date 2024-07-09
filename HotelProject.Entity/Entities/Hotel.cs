using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class Hotel:EntityBase
    {
        public string HotelName { get; set; }
        public string Location { get; set; } = "#";
        public string Number { get; set; }
        public string Email { get; set; }
        public string InstaLink { get; set; } = "#";
        public string FaceBookLink { get; set; } = "#";
        public string TwitterLink { get; set; } = "#";
        public string YoutubeLink { get; set; } = "#";
        public byte StarCount { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}
