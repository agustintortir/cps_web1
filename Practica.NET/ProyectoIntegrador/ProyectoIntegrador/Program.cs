using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Ciudad ciudad1 = new Ciudad(1, "Buenos Aires");

            Cliente cliente1 = new Cliente(1, "Agustin", Sexo.Masculino, "Ramirez", ciudad1, "11232233", "La Pampa 23", true);

            Producto producto1 = new Producto(1, "Descripción", 12200, "https:aaaaa.com");

            Comprobante comprobante1 = new Comprobante(new DateTime(2025,6,24), producto1, 200121, 2321);

            Orden orden1 = new Orden(1, producto1, cliente1, new DateTime(2025, 6, 24), 122);

            Console.WriteLine($"El cliente se llama: { cliente1.NombreCliente}");
            Console.WriteLine($"El cliente vive en: { cliente1.Ciudad}");
            Console.WriteLine($"Su telefono es:  {cliente1.Telefono}");
            Console.WriteLine($"Realizó una compra el: {orden1.FechaOrden}");
            Console.WriteLine($"Y en el comprobante figura que salió un total de: {comprobante1.TotalPrecio}");


        }
    }
}


