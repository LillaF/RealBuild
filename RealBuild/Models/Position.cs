using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealBuild.Models
{
    public class Position
    {
        public string PositionID { get; set; }
        public string ProductID { get; set; }
        public int ShelfID { get; set; }
        public int Facings { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public virtual Product Product { get; set; }
    }
}