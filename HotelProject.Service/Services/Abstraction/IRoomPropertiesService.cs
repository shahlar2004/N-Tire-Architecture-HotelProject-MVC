using HotelProject.Entity.DTOs.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Services.Abstraction
{
    public interface IRoomPropertiesService
    {
        Task< List<RoomPropertiesDTO>> GetAllRoomsIsNotDeleted();
    }
}
