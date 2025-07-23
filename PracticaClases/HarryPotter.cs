using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClases
{
    public class HarryPotter : Libro
    {
        public string numeroPelicula { get; set; }
        public string personajeFavorito { get; set; }

        public HarryPotter(string titulo, string autor, int anioPublicacion, string numeroPelicula, string personajeFavorito)
            : base(titulo, autor, anioPublicacion)
        {
            this.numeroPelicula = numeroPelicula;
            this.personajeFavorito = personajeFavorito;
        }
             public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: { Autor}");
            Console.WriteLine($"Año de Publicación: {AnioPublicacion}");
            Console.WriteLine($"Número de Película: {numeroPelicula}");
            Console.WriteLine($"Personaje Favorito: {personajeFavorito}");
        }
    }
}
