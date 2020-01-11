using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dereja3.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }

        public string CatagoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
