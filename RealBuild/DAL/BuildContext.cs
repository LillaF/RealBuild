using RealBuild.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RealBuild.DAL
{
    public class BuildContext : DbContext
    {
        public BuildContext() : base("BuildContext")
        {
        }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Realogram> Realograms { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Shelf> Shelfs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}