using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador
{
    public enum Sexo
    {
        Masculino = 1,
        Femenino = 2
    }
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public Sexo Sexo { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }


        public Cliente(int idCliente, string nombreCliente, Sexo sexo, string apellidoCliente, Ciudad ciudad, string telefono, string direccion , bool activo)
        {
            IdCliente = idCliente;
            NombreCliente = nombreCliente;
            Sexo = sexo;
            ApellidoCliente = apellidoCliente;
            Ciudad = ciudad;
            Telefono = telefono;
            Direccion = direccion;
            Activo = activo;
        }
    }
}
