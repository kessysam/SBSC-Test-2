using Microsoft.AspNetCore.Identity;
using SBSCFleetManagement.Common.Enum;

namespace SBSCFleetManagement.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public UserType UserType { get; set; }
    }
}
