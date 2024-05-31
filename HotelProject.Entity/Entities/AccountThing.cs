using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    internal class AccountThing:EntityBase
    {
        public string Title { get; set; }   
        public int Count { get; set; }
    }
}
