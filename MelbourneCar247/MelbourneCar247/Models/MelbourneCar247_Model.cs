namespace MelbourneCar247.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MelbourneCar247_Model : DbContext
    {
        public MelbourneCar247_Model()
            : base("name=MelbourneCar247_Model")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Reviews)
                .WithRequired(e => e.Booking)
                .HasForeignKey(e => e.Booking_BookingId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Car)
                .HasForeignKey(e => e.Car_CarId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);
        }
    }
}
