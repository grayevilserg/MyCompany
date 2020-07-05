using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "b812e847-8117-4449-b918-4a3f10242264",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "d394b27d-4cb5-4797-8365-f6668abfe7f7",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "",
                NormalizedEmail = "",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });
            
            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "b812e847-8117-4449-b918-4a3f10242264",
                UserId = "d394b27d-4cb5-4797-8365-f6668abfe7f7"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid( "fdc326ff-f95d-4f6d-be12-be88ddebea00"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("2c1935db-2909-489c-a95c-00429f09e77e"),
                CodeWord = "PageServices",
                Title = "Наши Услуги"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("b9a4e8ad-65b2-4f3a-b982-da2fbec93e9d"),
                CodeWord = "PageContacts",
                Title = "Наши Контакты"
            });

        }
    }
}
