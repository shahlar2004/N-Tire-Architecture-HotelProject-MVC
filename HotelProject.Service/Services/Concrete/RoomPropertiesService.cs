using AutoMapper;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.DTOs.Country;
using HotelProject.Entity.DTOs.RoomProperties;
using HotelProject.Entity.Entities;
using HotelProject.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Services.Concrete
{
    public class RoomPropertiesService : IRoomPropertiesService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RoomPropertiesService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task createRoomProperties(RoomPropertiesAddDTO roomPropertiesAddDTO)
        {
           
            var map = mapper.Map<RoomProperties>(roomPropertiesAddDTO);
          map.isInternet = roomPropertiesAddDTO.isInternetB == "Yes" ? true : false;
            await unitOfWork.GetRepository<RoomProperties>().AddAsync(map);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<RoomPropertiesDTO>> GetAllRoomPropertiesIsNotDeleted()
        {
            var roomProperties = await unitOfWork.GetRepository<RoomProperties>().GetAllAsync(x => !x.isDeleted,x=>x.Hotel,x=>x.RoomCategory,x=>x.Hotel.Country);
            var hotels = await unitOfWork.GetRepository<Hotel>().GetAllAsync(x=>!x.isDeleted);
            var map=mapper.Map<List<RoomPropertiesDTO>>(roomProperties);
            return map;
        }
    }
}
