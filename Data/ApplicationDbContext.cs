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
                new Category { Id = 1, Name = "Light", WeightMin = 0, WeightMax = 500, IconURL = "" },
                new Category { Id = 2, Name = "Medium", WeightMin = 500, WeightMax = 2500, IconURL = "" },
                new Category { Id = 3, Name = "Heavy", WeightMin = 2500, WeightMax = 999999, IconURL = "" }
            );

            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}
