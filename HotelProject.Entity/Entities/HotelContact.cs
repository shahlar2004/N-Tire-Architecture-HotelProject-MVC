using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class HotelContact:EntityBase
    {
        public string Location { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string InstaLink { get; set; } = "#";
        public string FaceBookLink { get; set; } = "#";
        public string TwitterLink { get; set; } = "#";
        public string YoutubeLink { get; set; } = "#";
    }
}
