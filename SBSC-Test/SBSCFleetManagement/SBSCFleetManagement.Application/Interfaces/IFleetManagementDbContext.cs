using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SBSCFleetManagement.Domain.Entities;


using System.Threading.Tasks;

namespace SBSCFleetManagement.Application.Interfaces
{
    public interface IFleetManagementDbContext
    {
        Task<int> TransactionCompletedAsync();
        DbSet<Fleet> Fleets { get; set; }
        DbSet<Trip> Trips { get; set; }
        DbSet<TripData> TripDatas { get; set; }
        DbSet<TripIncidence> TripIncidences { get; set; }
        DbSet<TripRequest> TripRequests { get; set; }
    }
}
