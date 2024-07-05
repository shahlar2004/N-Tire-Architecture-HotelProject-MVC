using HotelProject.Entity.DTOs.Category;
using HotelProject.Entity.DTOs.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.DTOs.Room
{
    public class RoomAddDTO
    {
        public string RoomNumber { get; set; }   
        public int PricePerNight { get; set; }
        public int AdultCount { get; set; }
        public int RoomCount { get; set; }
        public int ChildCount { get; set; }
        public string Description { get; set; }
        public string isInternet { get; set; }
        public Guid RoomCategoryId { get; set; }
        public Guid CountryId { get; set; }
        public List<CategoryDTO> Categories { get; set; }
        public List<CountryDTO> Countries { get; set; }       

    }
}
