using AutoMapper;
using HotelProject.Entity.DTOs.Room;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.AutoMapper
{
    public class RoomProfile:Profile
    {
        public RoomProfile()
        {
            CreateMap<RoomDTO,Room>().ReverseMap();
        }
    }
}
