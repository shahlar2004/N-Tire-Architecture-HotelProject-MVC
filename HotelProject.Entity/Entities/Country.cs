using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class Country:EntityBase
    {
        public string Name {  get; set; }   
        public ICollection<Hotel> Hotels { get; set; }
    }
}
