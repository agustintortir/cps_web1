using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Cupcakes.Models
{
    public class Bakery
    {
        [Key]
        public int BakeryId { get; set; }
        [StringLength(maximumLength:50, MinimumLength =4)]
        public string BakeryName { get; set; }
        [Range(1,40)]
        public int Quantity { get; set; }
        [StringLength(maximumLength:50, MinimumLength =4)]
        public string Adress { get; set; }
        public ICollection<Cupcake> Cupcakes { get; set; }

    }
}
