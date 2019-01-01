namespace TrafficTicketsSystem10.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TicketsManagementModel : DbContext
    {
        public TicketsManagementModel()
            : base("name=TicketsManagementModel")
        {
        }

        public virtual DbSet<Camera> Cameras { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<TrafficViolation> TrafficViolations { get; set; }
        public virtual DbSet<ViolationType> ViolationTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrafficViolation>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(8, 2);
        }
    }
}
