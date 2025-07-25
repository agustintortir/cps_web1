using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string UrlImagen { get; set; }

        public Producto(int id, string descripcion, double precio, string urlImagen)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            UrlImagen = urlImagen;
        }
    }
}
