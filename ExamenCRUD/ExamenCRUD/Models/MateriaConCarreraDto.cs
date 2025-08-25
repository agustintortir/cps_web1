namespace ExamenCRUD.Models
{
    public class MateriaConCarreraDto
    {
        public int CarreraId { get; set; }
        public string CarreraNombre { get; set; } = string.Empty;
        public int CarreraCuatrimestres { get; set; }
        public int MateriaId { get; set; }
        public string MateriaNombre { get; set; } = string.Empty;
        public string MateriaCuatrimestre { get; set; } = string.Empty;
    }
}
