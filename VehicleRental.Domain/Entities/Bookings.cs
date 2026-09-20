using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Domain.Enums;

namespace VehicleRental.Domain.Entities {
    public class Bookings {
        [Key]
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public Customers? Customer { get; set; }
        public int VehicleId { get; set; }
        public Vehicles? Vehicle { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDateExpected { get; set; }
        public DateTime? ReturnDateActual { get; set; }
        public decimal DailyRate { get; set; }
        public int NumberOfDays { get; set; }
        public decimal TotalAmount { get; set; }
        public BookingStatus Status { get; set; } = BookingStatus.Reserved;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<DamageReport> DamageReports { get; set; } = new List<DamageReport>();
    }
}
