using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Blazor.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Light", MinWeight = 0, MaxWeight = 500, IconURL = "https://www.flaticon.com/svg/static/icons/svg/1085/1085961.svg" },
                new Category { Id = 2, Name = "Medium", MinWeight = 500, MaxWeight = 2500, IconURL = "https://www.flaticon.com/svg/static/icons/svg/3662/3662796.svg" },
                new Category { Id = 3, Name = "Heavy", MinWeight = 2500, MaxWeight = 999999, IconURL = "https://www.flaticon.com/svg/static/icons/svg/3662/3662736.svg" }
            );

            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}
