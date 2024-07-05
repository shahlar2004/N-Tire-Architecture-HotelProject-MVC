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
    public class RoomCategoryMap : IEntityTypeConfiguration<RoomCategory>
    {
        public void Configure(EntityTypeBuilder<RoomCategory> builder)
        {
            builder.HasData(new RoomCategory
            {
                Id = Guid.Parse("{C44363BE-74A2-43E8-B8BE-6A5A69F49A7F}"),
                Name = "Junior Suite"
            },
            new RoomCategory
            {
                Id = Guid.Parse("{5024E694-BF92-4659-B456-CF664623EFE4}"),
                Name = "Executive Suite"
            },
            new RoomCategory
            {
                Id = Guid.Parse("{D529881B-6D1C-40FC-9EA3-0C29E4EF0691}"),
                Name = "Super Deluxe"
            }
            );
        }
    }
}
