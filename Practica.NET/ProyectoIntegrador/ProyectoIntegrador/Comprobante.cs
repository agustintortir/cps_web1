using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador
{
    class Comprobante 
    {
        public DateTime FechaComprobante { get; set; }
        public Producto ProductoComprobante { get; set; }
        public int TotalCantidad { get; set; }
        public double TotalPrecio { get; set; }

        public Comprobante(DateTime fechaComprobante, Producto productoComprobante, int totalCantidad, double totalPrecio) 
        {
            FechaComprobante = fechaComprobante;
            ProductoComprobante = productoComprobante;
            TotalCantidad = totalCantidad;
            TotalPrecio = totalPrecio;
        }
    }
}
