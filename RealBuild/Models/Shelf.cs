using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealBuild.Models
{
    public class Shelf
    {
        public int ShelfID { get; set; }
        public int SectionID { get; set; }
        public string Description { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public int Facings { get; set; }
        public int Type { get; set; }
        public int Notch { get; set; }
        public double LeftOverhang { get; set; }
        public double RightOverhang { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}