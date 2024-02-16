using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBulidAssignment3
{
    public class Product
    {
        public int PId { get; set; }
        public string? PName { get; set; }
        public string? PBrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}
