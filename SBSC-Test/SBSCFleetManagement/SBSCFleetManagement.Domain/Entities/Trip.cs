using SBSCFleetManagement.Common.Enum;
using System;
using System.Collections.Generic;

namespace SBSCFleetManagement.Domain.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        public int TripRequestId { get; set; }
        public int FleetId { get; set; }        
        public int ApplicationUserId { get; set; }
        public int UserId { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TripStatus TripStatus { get; set; }
        public DateTime Duration { get; set; }
        public virtual List<TripIncidence> TripIncidences { get; set; }
        public virtual List<TripData> TripDatas { get; set; }
    }
}
