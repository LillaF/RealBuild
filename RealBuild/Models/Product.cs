using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealBuild.Models
{
    public class Product
    {
        public string ProductID { get; set; }
        public string UPC { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public ICollection<Position> Positions { get; set; }

    }
}