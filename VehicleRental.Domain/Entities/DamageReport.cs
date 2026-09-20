using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Domain.Entities {
    public class DamageReport {
        [Key]
        public int DamageReportId { get; set; }
        public int BookingId { get; set; }
        public Bookings? Booking { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal EstimatedCost { get; set; }
        public string? PhotoPath { get; set; }
        public DateTime ReportedAt { get; set; } = DateTime.UtcNow;
    }
}
