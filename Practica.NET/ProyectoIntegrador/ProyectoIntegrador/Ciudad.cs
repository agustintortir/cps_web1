using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador
{
    public class Ciudad
    {
        public int Id_ciudad { get; set; }
        public string NombreCiudad { get; set; }

        public Ciudad(int id_ciudad, string nombreCiudad)
        {
            Id_ciudad = id_ciudad;
            NombreCiudad = nombreCiudad;
        }
    }
}
