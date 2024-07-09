using AutoMapper;
using HotelProject.Entity.DTOs.RoomProperties;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.AutoMapper
{
    public class RoomPropertiesProfile:Profile
    {
        public RoomPropertiesProfile()
        {
            CreateMap<RoomPropertiesDTO,RoomProperties>().ReverseMap();
            CreateMap<RoomPropertiesAddDTO, RoomProperties>().ReverseMap();
        }
    }
}
