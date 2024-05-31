using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Common
{
    public class EntityBase:IEntityBase
    {
        public int Id { get; set; } 
        public DateTime CreatedDate { get; set; }   
        public bool IsDeleted { get; set; } 
    }
}
