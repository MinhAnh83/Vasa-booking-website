using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VasaHotel.Models;
using VasaHotel_main.Areas.Identity.Data;

namespace VasaHotel_main.Areas.Identity.Data
{
    public class VasaHotelContext : IdentityDbContext<VasaHotelUser>
    {
        private object modelBuilder;

        public VasaHotelContext(DbContextOptions<VasaHotelContext> options)
            : base(options)
        {

        }  
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Typeroom> Type_room { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Blog> Blog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Typeroom>().ToTable(nameof(Type_room));
            modelBuilder.Entity<Booking>().ToTable(nameof(Booking))
                   .HasMany(c => c.Service);            
            modelBuilder.Entity<Customer>().ToTable(nameof(Customer))
                 .HasMany(c => c.Booking); ;
            modelBuilder.Entity<Room>()
                .ToTable(nameof(Room))
                .HasMany(c => c.Review); 
            modelBuilder.Entity<Service>().ToTable(nameof(Service))  ;
            modelBuilder.Entity<Blog>().ToTable(nameof(Blog));
            modelBuilder.Entity<Review>().ToTable(nameof(Review));
            base.OnModelCreating(modelBuilder);


            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
