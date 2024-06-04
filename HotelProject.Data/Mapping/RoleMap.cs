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
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
            new Role
            {
                Id = Guid.Parse("81D91823-EB61-4D17-A1FC-8A286F88F6D4"),
                Name = "Superadmin",
                NormalizedName = "SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },

           new Role
           {
               Id = Guid.Parse("4380FCF7-DF75-485F-888A-D7715BE71026"),
               Name = "Admin",
               NormalizedName = "ADMIN",
               ConcurrencyStamp = Guid.NewGuid().ToString()
           },

            new Role
            {
                Id = Guid.Parse("26C34F97-7D52-452B-8E70-48135D3756CD"),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }
           );
        }
    }
}
