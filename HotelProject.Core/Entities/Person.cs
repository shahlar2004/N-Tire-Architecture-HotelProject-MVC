using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DataTable BirthDate { get; set; }
        public string InstaLink { get; set; } = "#";
        public string FaceBookLink { get; set; } = "#";
        public string TwitterLink { get; set; } = "#";
        public string YoutubeLink { get; set; } = "#";
    }
}
