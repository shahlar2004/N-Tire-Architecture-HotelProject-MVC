using HotelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Data.Mapping
{
    public class RoomPropertiesMap : IEntityTypeConfiguration<RoomProperties>
    {
        public void Configure(EntityTypeBuilder<RoomProperties> builder)
        {
            RoomProperties roomProperties = new RoomProperties()
            {
                Id=Guid.Parse("{069FF25A-4962-42CF-B099-2635B6B172FF}"),
                RoomCommanName="1A",
                PricePerNight=100,
                AdultCount=2,
                ChildCount=2,
                Description="Good Luck!",
                RoomCount=4,
                RoomCategoryId=Guid.Parse("{C44363BE-74A2-43E8-B8BE-6A5A69F49A7F}"),
                HotelId=Guid.Parse("{28ABFEEA-3E87-4CBE-8809-4DCB111EA3FD}"),
                isInternet=true,
                isDeleted=false,
                BathCount=1,
                BedCount=3
                
            };
            builder.HasData(roomProperties);
        }
    }
}
