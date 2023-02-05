using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03NET___CJ_ASP_Travel3.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        // ShoppingCart
        // Order

        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
    }
}