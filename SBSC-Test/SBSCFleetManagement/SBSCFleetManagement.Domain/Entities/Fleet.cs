using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSCFleetManagement.Domain.Entities
{
    public class Fleet
    {
        public int Id { get; set; } 
        public string LicenseNo { get; set; }
        public string DeviceNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNo { get; set; }
        public string ChasisNo { get; set; }
        public string Color { get; set; }
        public string VehicleType { get; set; }
        public int PassengerSeats { get; set; }
        public string FuelType { get; set; }
        public virtual List<Trip> Trips { get; set; }
    }
}
