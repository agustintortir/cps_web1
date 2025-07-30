using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBPractica.Models
{
    public class AdmCliente
    {
        private SqlConnection conexion;

        private void Conectar()
        {
            string stringConexion = ConfigurationManager.ConnectionStrings["Conexion"].ToString();
            conexion = new SqlConnection(stringConexion);
        }

        public int Alta(Cliente pCliente)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("INSERT INTO Clientes1 (Nombre, Apellido, Email) VALUES (@nombre, @apellido, @email)", conexion);

            sentencia.Parameters.Add("@nombre", SqlDbType.VarChar);
            sentencia.Parameters.Add("@apellido", SqlDbType.VarChar);
            sentencia.Parameters.Add("@email", SqlDbType.VarChar);

            sentencia.Parameters["@nombre"].Value = pCliente.Nombre;
            sentencia.Parameters["@apellido"].Value = pCliente.Apellido;
            sentencia.Parameters["@email"].Value = pCliente.Email;

            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }

        public Cliente TraerCliente(int pCodigo)
        {
            Conectar();

            SqlCommand sentencia = new SqlCommand("SELECT codigo, nombre, apellido, email FROM Clientes1 WHERE codigo = @codigo", conexion);

            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;

            conexion.Open();

            SqlDataReader registros = sentencia.ExecuteReader();

            Cliente cliente = new Cliente();

            if (registros.Read())
            {
                cliente.Codigo = int.Parse(registros["codigo"].ToString());
                cliente.Nombre = registros["nombre"].ToString();
                cliente.Apellido = registros["apellido"].ToString();
                cliente.Email = registros["email"].ToString();
            }

            conexion.Close();

            return cliente;
        }
        public int Modificar(Cliente pCliente)
        {
            Conectar();

            SqlCommand sentencia = new SqlCommand("UPDATE Clientes1 SET nombre = @nombre, apellido = @apellido, email = @email WHERE codigo = @codigo", conexion);

            sentencia.Parameters.Add("@nombre", SqlDbType.VarChar);
            sentencia.Parameters["@nombre"].Value = pCliente.Nombre;

            sentencia.Parameters.Add("@apellido", SqlDbType.Int);
            sentencia.Parameters["@apellido"].Value = pCliente.Apellido;

            sentencia.Parameters.Add("@email", SqlDbType.Int);
            sentencia.Parameters["@email"].Value = pCliente.Email;

            conexion.Open();

            int i = sentencia.ExecuteNonQuery();

            conexion.Close();

            return i;
        }

        public int Borrar(int pCodigo)
        {
            Conectar();

            SqlCommand sentencia = new SqlCommand("DELETE FROM Clientes1 WHERE codigo = @codigo", conexion);

            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;

            conexion.Open();

            int i = sentencia.ExecuteNonQuery();

            conexion.Close();

            return i;
        }
    }
}