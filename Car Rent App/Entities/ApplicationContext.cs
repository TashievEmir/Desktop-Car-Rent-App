using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rent_App.Entities
{
    internal class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=CarRentApp; Username=postgres; Password=superuser");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u=>u.Id).HasName("UsersPK");
            modelBuilder.Entity<Car>().HasKey(u => u.Id).HasName("CarsPK");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
