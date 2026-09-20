using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Domain.Enums;

namespace VehicleRental.Domain.Entities {
    public class Payment {
        [Key]
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public Bookings? Booking { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string PaymentMethod { get; set; } = string.Empty;
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public string? TransactionReference { get; set; }
    }
}
