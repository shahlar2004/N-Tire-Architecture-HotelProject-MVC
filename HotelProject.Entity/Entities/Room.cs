using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class Room:EntityBase
    {
        public string RoomNumber { get; set; }
        public Guid RoomPropertiesId { get; set; }
        public bool Reserved { get; set; }
        public RoomProperties RoomProperties { get; set; }
    }
}
