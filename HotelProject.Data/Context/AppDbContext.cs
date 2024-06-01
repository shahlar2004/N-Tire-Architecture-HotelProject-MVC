using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelProject.Entity.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HotelProject.Data.Context
{
    public class AppDbContext:IdentityDbContext<AppUser,Role,Guid>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        DbSet<Image> Images { get; set; }
        DbSet<Services> Services { get; set; }
        DbSet<Status> Statuses { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<RoomCategory> RoomsCategory { get; set;}
        DbSet<Country> Countries { get; set; }
        DbSet<Booking> Bookings { get; set; }   
        DbSet<HotelContact> HotelContacts { get; set; }
        DbSet<AboutUs> AboutUs { get; set; }    
        DbSet<LuxuryLiving> LuxuryLivings { get; set; }
        DbSet<Video> Videos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new ArticleMap()); // bu sekilde tek tek daxil etmekvaxt itkisi oldugundan asagidaki kimi elave edilir.

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // modelBuilder.Entity<Article>().Property(x=>x.Tutle).HasMaxLength(50); birbasa burda da ede bilerik amma bu temiz kod yazmaq ucun yaxsi deyil.
            //elave class-da yazmagimiz daha yaxsidir.
        }


    }
}
