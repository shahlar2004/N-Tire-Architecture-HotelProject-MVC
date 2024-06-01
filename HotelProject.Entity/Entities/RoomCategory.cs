using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class RoomCategory:EntityBase
    {
        public string Name { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
