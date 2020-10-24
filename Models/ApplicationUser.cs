using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SportsManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int UserType { get; set; }
    }
}
