using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Dereja3.Models
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser() : base()
        {

        }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Product> Products { get; set; }
        
    }
}
