using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Domain.Entities;

namespace VehicleRental.Infrastructure.Data {
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<VehicleCategories> VehicleCategories { get; set; }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<DamageReport> DamageReports { get; set; }
        public DbSet<VehicleDocument> VehicleDocuments { get; set; }
        public DbSet<CustomerDocument> CustomerDocuments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehicles>()
                .HasIndex(v => v.PlateNumber)
                .IsUnique();

            modelBuilder.Entity<Customers>()
            .HasIndex(c => c.Email)
            .IsUnique();

            modelBuilder.Entity<Vehicles>()
                .HasOne(v => v.Category)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(v => v.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicles>()
                .HasOne(v => v.Branch)
                .WithMany(b => b.Vehicles)
                .HasForeignKey(v => v.BranchId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Bookings>()
            .HasOne(b => b.Vehicle)
            .WithMany(v => v.Bookings)
            .HasForeignKey(b => b.VehicleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Bookings>()
                .HasOne(b => b.Customer)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
