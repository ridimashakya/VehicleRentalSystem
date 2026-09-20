using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Domain.Entities {
    public  class Drivers {
        [Key]
        public int DriverId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string LicenseNumber { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public decimal DailyRate { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
