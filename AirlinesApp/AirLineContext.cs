using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlinesApp
{
    class AirlineContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirlineDatabase;Integrated Security=True;Connect Timeout=30"); //using @ to ignore the escape character
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity => 
            {
                entity.ToTable("Bookings");
                entity.HasKey(e => e.BookingID)
                      .HasName("PK_Bookings");

                entity.Property(e => e.BookingID)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress)
                      .IsRequired()
                      .HasMaxLength(50);

                //entity.HasOne(e => e.Flight)
                //      .WithMany()
                //      .HasForeignKey(e => e.FlightNumber);

            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("Flights");
                entity.HasKey(e => e.FlightNumber)
                      .HasName("PK_Flights");

                entity.Property(e => e.FlightStartAirport)
                      .IsRequired();

                entity.Property(e => e.FlightDestinationAirport)
                      .IsRequired();
            });
        }
    }
}
