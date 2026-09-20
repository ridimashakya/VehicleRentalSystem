using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Domain.Enums {
    [Flags]
    public enum VehicleFeatures {
        None = 0,
        AirConditioning = 1,
        GPS = 2,
        InsuranceIncluded = 4,
        ChildSeatAvailable = 8,
        BluetoothAudio = 16,
        Automatic4WD = 32
    }
}
