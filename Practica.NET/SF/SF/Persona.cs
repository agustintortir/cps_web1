using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    public class Persona
    {
        public string _apellido;
        public string _nombre;
        public int _dni;
        public int _telefono;

        public Persona(string apellido, string nombre, int dni, int telefono)
        {
            _apellido = apellido;
            _nombre = nombre;
            _dni = dni;
            _telefono = telefono;
        }
    }
}