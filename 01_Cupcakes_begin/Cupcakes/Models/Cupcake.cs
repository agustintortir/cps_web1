using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cupcakes.Models
{
    public class Cupcake
    {
        [Key]
        public int CupcakeId { get; set; }
        [Required(ErrorMessage ="Please select a cupcake type")]
        [Display(Name ="Cupcake type:")]
        public CupcakeType? CupcakeType { get; set; }
        [Required(ErrorMessage = "Please enter a cupcake description")]
        [Display(Name = "Description:")]
        public string Description { get; set; }
        [Display(Name = "Gluten free:")]
        public bool GlutenFree { get; set; }
        [Range(1, 15)]
        [Required(ErrorMessage = "Please enter the cupcake's price")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price:")]
        public double? Price { get; set; }
        [NotMapped]
        [Display(Name = "Cupcake picture:")]
        public IFormFile PhotoAvatar { get; set; }
        public string ImageName { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
        [Required(ErrorMessage = "Please select a bakery")]
        public int? BakeryId { get; set; }
        public Bakery bakery { get; set; }
        [Display(Name ="Caloric Value:")]
        public int CaloricValue { get; set; }
    }
}
