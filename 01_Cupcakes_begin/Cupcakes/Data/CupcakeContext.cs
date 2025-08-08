using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cupcakes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cupcakes.Data
{
    public class CupcakeContext : DbContext
    {
        public CupcakeContext(DbContextOptions<CupcakeContext> options) : base(options)
        {

        }
        public DbSet<Cupcake> Cupcakes { get; set; }
        public DbSet<Bakery> Bakerys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bakery>().HasData(
                new Bakery { BakeryId = 1, BakeryName = "Gluteus Free", Adress = "635 Brighton", Quantity = 8 } ,
                new Bakery { BakeryId = 2, BakeryName = "Cupcakes Free", Adress = "544 Haw", Quantity = 22 },
                new Bakery { BakeryId = 3, BakeryName = "Sugar Free", Adress = "232 as", Quantity = 30 },
                new Bakery { BakeryId = 4, BakeryName = "Charles Street", Adress = "223 fsa", Quantity = 18 }
                );
            modelBuilder.Entity<Cupcake>().HasData(
                new Cupcake { CupcakeId = 1, CupcakeType = CupcakeType.Birthday, Description = "Vanilla cupcake with choco cream", GlutenFree = true, Price = 2.5, BakeryId = 1, ImageMimeType = "image/jpeg", ImageName = "turquesa-cupcake.jpg", CaloricValue = 355  }  ,
                new Cupcake { CupcakeId = 2, CupcakeType = CupcakeType.Chocolate, Description = "Chocolate cupcake with butter cream", GlutenFree = false, Price = 3.2, BakeryId = 2, ImageMimeType = "image/jpeg", ImageName = "chocolate-cupcake.jpg", CaloricValue = 195 },
                new Cupcake { CupcakeId = 3, CupcakeType = CupcakeType.Strawberry, Description = "Strawberry cupcake with chocolate", GlutenFree = true, Price = 4, BakeryId = 3, ImageMimeType = "image/jpeg", ImageName = "pink-cupcake.jpg", CaloricValue = 295 }
                ); //CONTINUARRR
            
        }
    }
}
