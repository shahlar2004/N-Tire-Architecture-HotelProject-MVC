using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class Room:EntityBase
    {
        public string RoomNumber { get; set; }
        public int PricePerNight { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomCount { get; set; }
        public string Description { get; set; } 
        public bool isInternet { get; set; }
        public Guid RoomCategoryId { get; set; }   
        public RoomCategory RoomCategory { get; set; }
        public Guid CountryId { get; set; } 
        public Country Country { get; set; }
        public ICollection<Booking> Rooms { get; set; }


    }
}
