using HotelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Data.Mapping
{
    public class HotelMap:IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            Hotel hotel1 = new Hotel()
            {
                Id=Guid.Parse("{28ABFEEA-3E87-4CBE-8809-4DCB111EA3FD}"),
                HotelName="Hotel1",
                Number="+994509755489",
                Email="hotel1@gmail.com",
                CountryId= Guid.Parse("{F2D337CA-74FF-41CD-AEAE-8C152E818759}")

            };  Hotel hotel2 = new Hotel()
            {
                Id=Guid.Parse("{7612944D-845B-4AB3-9442-09805C12321F}"),
                HotelName="Hotel2",
                Number="+994519755489",
                Email="hotel2@gmail.com",
                CountryId= Guid.Parse("{F2D337CA-74FF-41CD-AEAE-8C152E818759}")

            };
            builder.HasData(hotel1, hotel2);
        }
    }
}
