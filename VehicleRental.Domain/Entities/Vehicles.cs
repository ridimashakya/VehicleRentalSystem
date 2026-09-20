using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Domain.Enums;

namespace VehicleRental.Domain.Entities {
    public class Vehicles {
        [Key]
        public int VehicleId { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public string PlateNumber { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int BranchId { get; set; }
        public decimal Mileage { get; set; }
        public string FuelType { get; set; } = string.Empty;
        public string Transmission { get; set; } = string.Empty;
        public decimal DailyRate { get; set; }
        public VehicleFeatures Features { get; set; }
        public string Status { get; set; } = "Available";
        public string? ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public VehicleCategories? Category { get; set; }
        public Branches? Branch { get; set; }
        public ICollection<Bookings> Bookings { get; set; } = new List<Bookings>();
    }
}
