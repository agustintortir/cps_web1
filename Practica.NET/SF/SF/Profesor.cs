using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class Profesor : Persona
    {
        public string _dia;
        public string _cursoProfe;
        public Profesor(string apellido, string nombre, int dni, int telefono, string dia, string cursoProfe) : base(apellido, nombre, dni, telefono)
        {
            dia = _dia;
            cursoProfe = _cursoProfe;
        }
    }
}
