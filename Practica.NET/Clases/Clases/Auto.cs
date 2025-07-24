using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Auto
    {
        protected double _velocidad = 0;
        private string _marca;
        private string _modelo;
        private string _color;

        public Auto(string marca, string modelo, string color)
        {
            _marca = marca;
            _modelo = modelo;
            _color = color;
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public double velocidad
        {
            get { return _velocidad; }
        }

        public void acelerar(double cantidad)
        {
            Console.WriteLine("-- Incrementando velocidad en {0} km/h", cantidad);
            _velocidad += cantidad;
        }
        public void girar(double cantidad)
        {
            Console.WriteLine("-- Girando {0} grados", cantidad);
        }
        public void frenar (double cantidad)
        {
            Console.WriteLine("-- Reduciendo velocidad en {0} km/h", cantidad);
            _velocidad -= cantidad;
        }
        public void estacionar()
        {
            Console.WriteLine("--- Estacionando auto");
            _velocidad = 0;
        }
    }
}
