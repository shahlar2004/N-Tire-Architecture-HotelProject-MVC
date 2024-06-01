using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Entities
{
    public class Content:EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; } 
    }
}
