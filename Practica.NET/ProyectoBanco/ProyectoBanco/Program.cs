using System;

namespace ProyectoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cliente cliente1 = new Cliente("Agustin", 29384);

            cliente1.depositar();
        }
    }
}
