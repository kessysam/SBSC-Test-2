using SBSCFleetManagement.Common.Enum;
using System;

namespace SBSCFleetManagement.Domain.Entities
{
    public class TripRequest
    {
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public string Destination { get; set; }
        public string CurrentLocation { get; set; }
        public DateTime Time { get; set; }
        public int? TripId { get; set; }
        public virtual Trip Trip { get; set; }
        public TripRequestStatus TripRequestStatus { get; set; }
    }
}
