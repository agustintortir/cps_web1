using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBPractica.Models
{
    public class AdmArticulo
    {
        private SqlConnection conexion;
        private void Conectar()
        {
            string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ToString();
            conexion = new SqlConnection(Conexion);
        }

        public int Alta(Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("INSERT INTO Articulos (Codigo, Descripcion, Precio) VALUES (@codigo, @descripcion, @precio)", conexion);

            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters.Add("@precio", SqlDbType.Float);

            sentencia.Parameters["@codigo"].Value = pArticulo.Codigo;
            sentencia.Parameters["@descripcion"].Value = pArticulo.Descripcion;
            sentencia.Parameters["@precio"].Value = pArticulo.Precio;

            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }
        public List<Articulo> TraerTodos()
        {
            Conectar();

            List<Articulo> articulos = new List<Articulo>();

            SqlCommand sentencia = new SqlCommand("SELECT codigo, descripcion, precio FROM Articulos", conexion);
            conexion.Open();
            SqlDataReader registros = sentencia.ExecuteReader();

            while (registros.Read())
            {
                Articulo articulo = new Articulo
                {
                    Codigo = int.Parse(registros["codigo"].ToString()),
                    Descripcion = registros["descripcion"].ToString(),
                    Precio = float.Parse(registros["precio"].ToString())

                };
                articulos.Add(articulo);
            }
            conexion.Close();
            return articulos;
        }

        public Articulo TraerArticulo(int pCodigo)
        {
            Conectar();
            
            SqlCommand sentencia = new SqlCommand("SELECT Codigo, Descripcion, Precio FROM Articulos WHERE Codigo = @codigo", conexion);

            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;

            conexion.Open();

            SqlDataReader registros = sentencia.ExecuteReader();

            Articulo articulo = new Articulo();

            if (registros.Read())
            {
                articulo.Codigo = int.Parse(registros["codigo"].ToString());
                articulo.Descripcion = registros["descripcion"].ToString();
                articulo.Precio = float.Parse(registros["precio"].ToString());
            }

            conexion.Close();

            return articulo;
        }
        public int Modificar(Articulo pArticulo)
        {
            Conectar();

            SqlCommand sentencia = new SqlCommand("UPDATE Articulos SET descripcion = @descripcion, precio = @precio WHERE codigo = @codigo", conexion);

            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters["@descripcion"].Value = pArticulo.Descripcion;

            sentencia.Parameters.Add("@precio", SqlDbType.Int);
            sentencia.Parameters["@precio"].Value = pArticulo.Precio;

            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pArticulo.Codigo;

            conexion.Open();

            int i = sentencia.ExecuteNonQuery();

            conexion.Close();

            return i;
        }

        public int Borrar(int pCodigo)
        {
            Conectar();

            SqlCommand sentencia = new SqlCommand("DELETE FROM Articulos WHERE codigo = @codigo", conexion);

            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;

            conexion.Open();

            int i = sentencia.ExecuteNonQuery();

            conexion.Close();

            return i;
        }
    }
}