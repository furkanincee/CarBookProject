using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class CarBookContext : IdentityDbContext<AppUser,AppRole,int> // tabloların prksı string olarak geliyor burada keye int vererek değiştiriyoruz int gelsin diye.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FURKAN5\\MSSQLSERVER2; initial catalog=CarBookDb;integrated Security=true");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Price> Prices { get; set; } 
        public DbSet<Service> Services { get; set; } 
        public DbSet<HowItWorksStep> HowItWorksSteps { get; set; } 
        public DbSet<CarDetail> CarDetails { get; set; } 
    }
}
