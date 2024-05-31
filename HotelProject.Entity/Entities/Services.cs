using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Data.Mapping
{
    public class Services:EntityBase
    {
        public string IconLink { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 

    }
}
