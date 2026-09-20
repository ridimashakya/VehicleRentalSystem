using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Domain.Entities {
    public class Branches {
        [Key]
        public int BranchId { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public ICollection<Vehicles> Vehicles { get; set; } = new List<Vehicles>();
    }
}
