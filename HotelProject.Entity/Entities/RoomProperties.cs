using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class RoomProperties:EntityBase,IEntityBase
    {
        public string RoomCommanName { get; set; }
        public int PricePerNight { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomCount { get; set; }
        public string Description { get; set; } 
        public bool isInternet { get; set; }
        public Guid RoomCategoryId { get; set; }   
        public RoomCategory RoomCategory { get; set; }
        public ICollection<Image> Images { get; set;}
        public ICollection<Room> Rooms { get; set;}
        public byte BathCount { get; set; }
        public byte BedCount { get; set; }
        public Guid HotelId { get; set; }   
        public Hotel Hotel { get; set; }
    }
}
