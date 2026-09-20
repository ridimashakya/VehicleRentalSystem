using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Domain.Entities {
    public class Customers {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string DrivingLicenseNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public ICollection<Bookings> Bookings { get; set; } = new List<Bookings>();
        public ICollection<CustomerDocument> Documents { get; set; } = new List<CustomerDocument>();
    }
}
