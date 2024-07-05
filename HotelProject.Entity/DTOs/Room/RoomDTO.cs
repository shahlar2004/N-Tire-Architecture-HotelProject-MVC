using HotelProject.Entity.DTOs.Category;
using HotelProject.Entity.DTOs.Country;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.DTOs.Room
{
    public class RoomDTO
    {
        public Guid Id {  get; set; }   
        public string RoomNumber { get; set; }
        public int PricePerNight { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomCount { get; set; }
        public string Description { get; set; }
        public bool isInternet { get; set; }
        public DateTime CreatedDate { get; set; }
        public CategoryDTO RoomCategory { get; set; }
        public CountryDTO Country { get; set; }
        //public HotelProject.Entity.Entities.Country Country { get; set; }

    }
}