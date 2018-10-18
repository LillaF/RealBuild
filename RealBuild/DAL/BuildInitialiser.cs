using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RealBuild.Models;

namespace RealBuild.DAL
{
    public class BuildInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<BuildContext>
    {
        protected override void Seed(BuildContext context)
        {
            var realograms = new List<Realogram>
            {
                new Realogram {Name="Burkes",Type=Models.Type.A,Chain="Burkes",Location="Naas-Main St",User="Lilla",Password="Lilla001",CreateDate=DateTime.Parse("2018-10-15") }
            };

            //           realograms.ForEach(s => context.Realograms.Add(s));
            //           context.SaveChanges();


            var sections = new List<Section>
            {
                new Section { SectionID="CREAMS",RealoGramLogID=1,Name="SamplePlan" ,Dept="",Height=50,Width=100,Depth=25,BaseHeight=0,BaseWidth=0,BackBoardDepth=1,UseNotchBars=false,NotchHeight=0,NotchWidth=0,NotchStart=0,NotchSpacing=0}
            };

            //           sections.ForEach(s => context.Sections.Add(s));
            //           context.SaveChanges();

            var shelves = new List<Shelf>
            {
                new Shelf { ShelfID = 1, SectionID = 1,Description = "A1", Height = 1, Width = 100, Depth = 40, X = 0, Y = 0, Z = 0, Facings = 13, Type = 0, Notch = 0, LeftOverhang = 0, RightOverhang = 0},
                new Shelf { ShelfID = 2, SectionID = 1,Description = "A2", Height = 1, Width = 100, Depth = 40, X = 0,Y = 27, Z = 0, Facings = 13, Type = 0, Notch = 0, LeftOverhang = 0, RightOverhang = 0},
                new Shelf { ShelfID = 3, SectionID = 1,Description = "A3", Height = 1, Width = 100, Depth = 40, X = 0,Y = 47, Z = 0, Facings = 15, Type = 0, Notch = 0, LeftOverhang = 0, RightOverhang = 0}

            };

            //           shelves.ForEach(s => context.Shelfs.Add(s));
            //           context.SaveChanges();

            var positions = new List<Position>
            {
                new Position {PositionID="3574661251660",ProductID="3574661251660",ShelfID=2,Facings=7,X=0,Y=28,Z=25},
                new Position {PositionID="3574660490466",ProductID="3574660490466",ShelfID=2,Facings=6,X=59.5,Y=28,Z=25},
                new Position {PositionID="3574660536799",ProductID="3574660536799",ShelfID=1,Facings=4,X=0,Y=1,Z=25},
                new Position {PositionID="3574660339673",ProductID="3574660339673",ShelfID=3,Facings=4,X=0,Y=48,Z=25},
                new Position {PositionID="3574660332490",ProductID="3574660332490",ShelfID=3,Facings=3,X=23.2,Y=48,Z=25},
                new Position {PositionID="3574661250984",ProductID="3574661250984",ShelfID=3,Facings=8,X=39.7,Y=48,Z=25},
                new Position {PositionID="3574660332865",ProductID="3574660332865",ShelfID=1,Facings=4,X=36,Y=1,Z=25},
                new Position {PositionID="3574661288826",ProductID="3574661288826",ShelfID=1,Facings=5,X=66,Y=1,Z=25}
            };
            //           positions.ForEach(s => context.Positions.Add(s));
            //           context.SaveChanges();

            var products = new List<Product>
            {

            new Product {ProductID="3574660536799",UPC="3574660536799",Name="AVEENO SHOWER OIL 400ML",Supplier="",Category="AVEENO",SubCategory="SKINCARE_MED_REG",Height=20,Width=9,Depth=5},
            new Product {ProductID="3574661251660",UPC="3574661251660",Name="AVEENO DERMEXA BODY WASH 1",Supplier="",Category="AVEENO",SubCategory="SKINCARE_MED_REG",Height=18.5,Width=8.5,Depth=5.2},
            new Product {ProductID="3574660490466",UPC="3574660490466",Name="AVEENO DERMEXA MOISTURISING CREAM 200ML",Supplier="",Category="AVEENO",SubCategory="SKINCARE_MED_REG",Height=19,Width=6.7,Depth=5.5},
            new Product {ProductID="3574660332490",UPC="3574660332490",Name="AVEENO CREAM",Supplier="",Category="AVEENO",SubCategory="SKINCARE_MED_REG",Height=15,Width=5.5,Depth=4.5},
            new Product {ProductID="3574661250984",UPC="3574661250984",Name="AVEENO DAILY MOISTURISING LORION PUMP",Supplier="",Category="AVEENO",SubCategory="SKINCARE_MED_REG",Height=18,Width=7.5,Depth=7.3},
            new Product {ProductID="3574660332865",UPC="3574660332865",Name="AVEENO BABY DAILY CARE BARRIER CREAM",Supplier="",Category="AVEENO",SubCategory="SKINCARE_MED_REG",Height=18.2,Width=7.5,Depth=5.2},
            new Product {ProductID="3574660339673",UPC="3574660339673",Name="AVEENO ULTRA CLAM MOIST SPF20",Supplier="",Category="AVEENO",SubCategory="SKINCARE_MED_REG",Height=14.5,Width=5.8,Depth=2.8},
            new Product {ProductID="3574661288826",UPC="3574661288826",Name="AVEENO AFTER SHOWER MIST",Supplier="",Category="AVEENO",SubCategory="SKINCARE_MED_REG",Height=21.5,Width=6.5,Depth=5.5}

            };
            //           products.ForEach(s => context.Products.Add(s));
            //           context.SaveChanges();
        }
    }
}