using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoBanco
{
    class Banco : Cliente
    {

        public Banco(string nombreCliente, long monto) : base(nombreCliente, monto)
        {
        }

        public void depositosTotales()
        {
            Console.WriteLine("Ha depositado {0} veces", cantDepositos);
        }

    }
}
