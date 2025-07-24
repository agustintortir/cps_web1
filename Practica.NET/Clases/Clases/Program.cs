using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Renault", "Duster", "Rojo");
            Console.WriteLine("Los datos del coche son:");
            Console.WriteLine("Marca: {0}", auto1.Marca);
            Console.WriteLine("Modelo: {0}", auto1.Modelo);
            Console.WriteLine("Color: {0}", auto1.Color);


            auto1.acelerar(100);
            Console.WriteLine("El auto esta acelerando a {0} km/h \n", auto1.velocidad);

            auto1.frenar(75);
            Console.WriteLine("La velcidad actual es de {0} km/h \n", auto1.velocidad);

            auto1.girar(45);
            Console.WriteLine("La velocidad actual es de {0} km/h \n", auto1.velocidad);
        }
    }
}
