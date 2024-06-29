using AutoMapper;
using HotelProject.Entity.DTOs.Category;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.AutoMapper
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDTO,RoomCategory>().ReverseMap();
            CreateMap<CategoryUpdateDTO,RoomCategory>().ReverseMap();
            CreateMap<RoomCategory,CategoryUpdateDTO > ().ReverseMap();
            CreateMap<CategoryAddDTO,RoomCategory>().ReverseMap();  
        }
    }
}
