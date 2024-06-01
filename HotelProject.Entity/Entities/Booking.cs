using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class Booking:EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }   
        public int ChildCount { get; set; }
        public int AdultCount { get; set; }
        public int RoomCount { get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        public string Sms { get; set; }
    }
}
