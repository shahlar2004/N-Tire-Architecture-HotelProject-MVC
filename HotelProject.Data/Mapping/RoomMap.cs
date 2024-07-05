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
    public class RoomMap : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(x => new { x.Id });

            //builder.HasData
            //    (
            //    new Room
            //    {
            //        Id = Guid.Parse("{D23777FE-79AF-42B6-A81C-259205E1C314}"),
            //        RoomNumber = "1a",
            //        PricePerNight = 100,
            //        AdultCount = 2,
            //        ChildCount = 1,
            //        RoomCount = 4,
            //        Description = "Grand Duayen, Tunalı Hilmi Caddesi ve Kızılay Meydanı hedeflerine 5 dakikalık sürüş mesafesindedir. Misafirler spada masaj ile kendilerini şımartabilir ve restoran olanağından yararlanıp bir şeyler atıştırabilir. Ayrıca Anıtkabir ve Armada Shopping and Business Center kısa bir sürüş mesafesindedir. Misafirler arasında yardıma hazır personel ve konum popüler. ",
            //        isInternet = true,
            //        RoomCategoryId = Guid.Parse("{C44363BE-74A2-43E8-B8BE-6A5A69F49A7F}"),
            //        CountryId = Guid.Parse("{F2D337CA-74FF-41CD-AEAE-8C152E818759}"),
            //    }
            //    );
        }
    }
}
