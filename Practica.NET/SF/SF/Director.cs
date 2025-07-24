using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class Director : Profesor
    {
        public int _nroInsti;
        public Director(string apellido, string nombre, int dni, int telefono, int nroInsti, string dia, string cursoProfe) : base(apellido, nombre, dni, telefono, dia, cursoProfe)
        {
            nroInsti = _nroInsti;
        }
    }
}