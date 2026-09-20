using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Domain.Entities {
    public class VehicleCategories {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public decimal DailyRateBase { get; set; }
        public ICollection<Vehicles> Vehicles { get; set; } = new List<Vehicles>();
    }
}
