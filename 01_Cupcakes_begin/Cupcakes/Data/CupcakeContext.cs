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
            modelBuilder.Entity<Cupcake>().HasData(); //CONTINUARRR
            
        }
    }
}
