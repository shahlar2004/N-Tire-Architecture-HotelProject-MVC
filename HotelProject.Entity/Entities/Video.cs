using HotelProject.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Entities
{
    public class Video:EntityBase
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Video> Videos { get; set;}
    }
}
