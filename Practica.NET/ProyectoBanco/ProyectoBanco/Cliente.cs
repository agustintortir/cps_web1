using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoBanco
{
    class Cliente
    {
        public string _nombreCliente;
        public long _monto;
        public int cantDepositos = 0;


        public Cliente (string nombreCliente, long monto)
        {
            _nombreCliente = nombreCliente;
            _monto = monto;
            }
        public void depositar()
        {
            int deposito = 0;
            Console.WriteLine("Cuanto desea depositar");
            deposito = int.Parse(Console.ReadLine());
            _monto = _monto+deposito;
            Console.WriteLine("Ahora su monto actual es de: {0}", deposito);
            cantDepositos++;
        }

        public void extraer()
        {
            int extraccion = 0;
            Console.WriteLine("Cuanto desea extraer");
            extraccion = int.Parse(Console.ReadLine());
            _monto -= extraccion;
            Console.WriteLine("Ahora su monto actual es de: {0}", extraccion);
        }
    }
 }

