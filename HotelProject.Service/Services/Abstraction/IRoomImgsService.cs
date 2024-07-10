using HotelProject.Entity.DTOs.RoomImgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Services.Abstraction
{
    public interface IRoomImgsService
    {
        Task<List<RoomImgsDTO>> GetAllRoomsPropertiesForImagesIsNonDeleted();
    }
}
