using HotelProject.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var admin = new AppUser()
            {
                Id = Guid.Parse("E0C8114C-578E-4D0A-84D9-D936E0F34A7C"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "+905439999988",
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                FirstName = "Jako",
                LastName = "Ismo",
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("{53C70E42-4494-47E0-8391-43AED02DADD3}")
            };


            var superadmin = new AppUser()
            {
                Id = Guid.Parse("{B5C0033F-E7F1-4610-A19C-FA970C039602}"),
                UserName = "superadmin@gmail.com",
                NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                PhoneNumber = "+905439999988",
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                FirstName = "Jako",
                LastName = "Ismo",
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("{53C70E42-4494-47E0-8391-43AED02DADD3}")
            };



            admin.PasswordHash = CreatePasswordHash(admin, "123456");
            superadmin.PasswordHash = CreatePasswordHash(superadmin, "123456");

            builder.HasData(admin, superadmin);
        }
        private string CreatePasswordHash(AppUser user, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
