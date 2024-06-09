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
    public class CountryMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(new Country
            {
                Id= Guid.Parse("{F2D337CA-74FF-41CD-AEAE-8C152E818759}"),
                Name="Azərbaycan"
            },
            new Country
            {
                Id = Guid.Parse("{640D6FBF-72AF-4EB1-A276-FCAF7BEDF870}"),
                Name = "Rusiya"
            },
            new Country
            {
                Id = Guid.Parse("{FAA451A4-2CA8-4553-AD86-82607A771EB6}"),
                Name = "Türkiyə"
            }
            );
        }
    }
}
