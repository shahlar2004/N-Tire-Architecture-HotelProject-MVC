using AutoMapper;
using HotelProject.Data.Migrations;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.DTOs.RoomImgs;
using HotelProject.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Services.Concrete
{
    internal class RoomImgsService : IRoomImgsService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RoomImgsService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
       public async Task<List<RoomImgsDTO>> GetAllRoomsPropertiesForImagesIsNonDeleted()
        {
            var roomProperties = await unitOfWork.GetRepository<Entity.Entities.RoomProperties>().GetAllAsync(x=>!x.isDeleted) ;
            var map= mapper.Map<List<RoomImgsDTO>>(roomProperties) ;  
            return map ;
        }
    }
}
