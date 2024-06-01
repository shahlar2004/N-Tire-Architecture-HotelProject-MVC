using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class LuxuryLiving:Content
    {
        public Guid? VideoId { get; set; }
        public Video Video { get; set; }
        public Guid RoomId { get; set; }
        public ICollection<Room> Rooms { get; set; }

    }
}
