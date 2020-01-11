using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dereja3.Models
{
    public class Product
    {
       
        public int ProductId { get; set; }
        
        public String Name { get; set; }

        public string Description { get; set; }

        public int CatagoryId { get; set; }

        public string AddedById { get; set; }

        

        public Catagory Catagory { get; set; }
        public ApplicationUser AddedBy { get; set; }

    }
}
