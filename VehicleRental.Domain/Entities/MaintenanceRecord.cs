using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Domain.Entities {
    public class MaintenanceRecord {
        [Key]
        public int MaintenanceRecordId { get; set; }
        public int VehicleId { get; set; }
        public Vehicles? Vehicle { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
    }
}
