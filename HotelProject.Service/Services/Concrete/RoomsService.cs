using AutoMapper;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.DTOs.Room;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Services.Concrete
{
    public class RoomsService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RoomsService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async List<RoomDTO> GetAllRoomsIsNotDeleted()
        {
           var items= await unitOfWork.GetRepository<Room>().GetAllAsync(x=>!x.isDeleted);
           var map= mapper.Map<RoomDTO>(items);
           return map;
        }
    }
}
