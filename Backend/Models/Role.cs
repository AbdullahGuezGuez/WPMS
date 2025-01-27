using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Backend.Models
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
        public int? OrganizationId { get; set; }
    }
}