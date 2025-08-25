using System.ComponentModel.DataAnnotations;

namespace ExamenCRUD.Models
{
    public class Carrera
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Range(1, 20)]
        public int Cuatrimestres { get; set; }

        public ICollection<Materia> Materias { get; set; } = new List<Materia>();
    }
}
