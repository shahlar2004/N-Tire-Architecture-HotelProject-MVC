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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("{53C70E42-4494-47E0-8391-43AED02DADD3}"),
                FileName = "Images/BlogPhoto",
                FileType = "Jpg",
                CreatedBy = "Shahlar Ismayilov",
                CreatedDate = DateTime.Now,
            });
        }
    }
}
