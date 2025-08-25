using System.ComponentModel.DataAnnotations;

namespace ExamenCRUD.Models
{
    public class Materia
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string Cuatrimestre { get; set; } = string.Empty; 

        [Display(Name = "Carrera")]
        public int CarreraId { get; set; }
        public Carrera? Carrera { get; set; }
    }
}
