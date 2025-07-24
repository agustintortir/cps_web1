using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class Alumno : Persona
    {
        public string _curso;
        public string _horario;
        public int _edad;
        public Alumno(string apellido, string nombre, int edad, int dni, int telefono, string curso, string horario) : base (apellido, nombre, dni, telefono)
        {
            _curso = curso;
            _horario = horario;
            _edad = edad;
        }

        public void esMayor()
        {
            if (_edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            } else { Console.WriteLine("Es menor de edad"); }
        }
    }
}