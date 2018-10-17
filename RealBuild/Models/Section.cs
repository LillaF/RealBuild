using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealBuild.Models
{
    public class Section
    {
        public string SectionID { get; set; }
        public int RealoGramLogID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal BaseHeight { get; set; }
        public decimal BaseWidth { get; set; }
        public decimal BaseDepth { get; set; }
        public decimal BackBoardDepth { get; set; }
        public int Segments { get; set; }
        public bool UseNotchBars { get; set; }
        public decimal NotchHeight { get; set; }
        public decimal NotchWidth { get; set; }
        public decimal NotchStart { get; set; }
        public decimal NotchSpacing { get; set; }

        public virtual Realogram RealogramLogs { get; set; }
        // public virtual Shelf Shelves { get; set; } 
    }
}