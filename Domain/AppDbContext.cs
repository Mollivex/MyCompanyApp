using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompanyApp.Domain.Entities;

/*
 *      In this AppDbContext class inherited from IdentityDbContext<IdentityUser> 
 * we create database context to connect application with database.
 */

namespace MyCompanyApp.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "077f2d17-0151-4a4e-b2d5-6a74b4d05127",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "169e00d8-226e-447e-b32b-386471434c56",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "077f2d17-0151-4a4e-b2d5-6a74b4d05127",
                UserId = "169e00d8-226e-447e-b32b-386471434c56"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("e8a35e6e-2ec6-472d-b09d-7861c02daab1"),
                CodeWord = "PageIndex",
                Title = "Main page"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("15627982-3663-481d-9ba1-a91757b92bd3"),
                CodeWord = "PageServices",
                Title = "Our Services"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("1a9012e6-a71f-4faa-ae8a-34ecf1e2f14d"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });
        }
    }
}
