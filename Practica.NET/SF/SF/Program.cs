using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("White", "Walter", 20, 45854221, 11929923, "Tercero", "Tarde");
            Console.WriteLine("El alumno se llama: {0}", alumno1._nombre);
            Console.WriteLine("El alumno tiene {0} años", alumno1._edad);

            alumno1.esMayor();
            Console.ReadLine();
        }
    }
}
