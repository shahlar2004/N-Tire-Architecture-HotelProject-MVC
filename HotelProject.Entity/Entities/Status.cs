using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class Status:EntityBase
    {
        public string Name { get; set; }
        public ICollection<AppUser>? Users { get; set; }
    }
}
