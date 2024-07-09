using HotelProject.Entity.DTOs.Category;
using HotelProject.Entity.DTOs.Country;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.DTOs.RoomProperties
{
    public class RoomPropertiesAddDTO
    {
        public string RoomCommanName { get; set; }
        public int PricePerNight { get; set; }
        public int AdultCount { get; set; }
        public int RoomCount { get; set; }
        public int ChildCount { get; set; }
        public string Description { get; set; }
        public string isInternetB { get; set; }
        public Guid RoomCategoryId { get; set; }
        public Guid HotelId { get; set; }

        public byte StarCount { get; set; }

        public byte BathCount { get; set; }
        public byte BedCount { get; set; }
        public List<CategoryDTO> Categories { get; set; }
        public List<Hotel> Hotels { get; set; }

    }
}
