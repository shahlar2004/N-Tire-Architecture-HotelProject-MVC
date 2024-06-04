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
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(new UserRole
            {
                UserId = Guid.Parse("E0C8114C-578E-4D0A-84D9-D936E0F34A7C"),
                RoleId = Guid.Parse("4380FCF7-DF75-485F-888A-D7715BE71026")
            },

         new UserRole
         {
             UserId = Guid.Parse("{B5C0033F-E7F1-4610-A19C-FA970C039602}"),
             RoleId = Guid.Parse("81D91823-EB61-4D17-A1FC-8A286F88F6D4")
         }
         );
        }
    }
}
