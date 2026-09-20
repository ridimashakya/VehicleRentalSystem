using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Domain.Entities {
    public class InsurancePolicy {
        [Key]
        public int InsurancePolicyId { get; set; }
        public int VehicleId { get; set; }
        public Vehicles? Vehicle { get; set; }
        public string PolicyNumber { get; set; } = string.Empty;
        public string Provider { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal CoverageAmount { get; set; }
    }
}
