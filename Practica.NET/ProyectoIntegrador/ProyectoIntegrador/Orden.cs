using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public Producto ProductoOrdenado { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaOrden { get; set; }
        public decimal Precio { get; set; }

        public Orden(int idOrden, Producto productoOrdenado, Cliente cliente, DateTime fechaOrden, decimal precio)
        {
            IdOrden = idOrden;
            ProductoOrdenado = productoOrdenado;
            Cliente = cliente;
            FechaOrden = fechaOrden;
            Precio = precio;
        }

    }
}
