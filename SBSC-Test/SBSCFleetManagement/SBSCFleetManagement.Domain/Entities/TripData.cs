using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSCFleetManagement.Domain.Entities
{
    public class TripData
    {
        public int Id { get; set; }
        public int TripId { get; set; } 
        public string Speed { get; set; }
        public string FuelConsumption { get; set; }
        public string VehicleTemperature { get; set; }
        public int VehicleStops { get; set; }
        public DateTime Time { get; set; }        
    }
}
