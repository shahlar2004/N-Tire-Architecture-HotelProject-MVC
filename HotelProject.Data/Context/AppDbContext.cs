using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelProject.Entity.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Reflection;

namespace HotelProject.Data.Context
{
    public class AppDbContext:IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new ArticleMap()); // bu sekilde tek tek daxil etmekvaxt itkisi oldugundan asagidaki kimi elave edilir.


            base.OnModelCreating(modelBuilder); //sonradan elave etdik: identity

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // modelBuilder.Entity<Article>().Property(x=>x.Tutle).HasMaxLength(50); birbasa burda da ede bilerik amma bu temiz kod yazmaq ucun yaxsi deyil.
            //elave class-da yazmagimiz daha yaxsidir.
        }


    }
}
