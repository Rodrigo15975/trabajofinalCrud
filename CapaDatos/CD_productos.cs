using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CapaDatos
{
    public class CD_productos
    {
        public CD_conexion conexion = new CD_conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();

            tabla.Load(leer);

            conexion.cerrarConexion();
            return tabla;
        }

        public void insertarProducto(string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();          


        }
        public void actualizarProducto(string nombre, string desc, string marca, double precio, int stock, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
         public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        



    }
}
