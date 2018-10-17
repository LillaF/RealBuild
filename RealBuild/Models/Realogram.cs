using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealBuild.Models
{
    public enum Type
    {
        A, B, C, D, E, F, G, H
    }
    public class Realogram

    {
        [Required]
        public int RealoGramID { get; set; }
        public string Name { get; set; }
        public Type? Type { get; set; }
        public string Chain { get; set; }
        public string Location { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
    }
}