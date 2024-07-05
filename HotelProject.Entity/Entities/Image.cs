using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class Image:EntityBase
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<AppUser>? Images { get; set;}
        public Guid? RoomPropertiesId { get; set; }
        public RoomProperties? RoomProperties { get; set; }
    }
}
