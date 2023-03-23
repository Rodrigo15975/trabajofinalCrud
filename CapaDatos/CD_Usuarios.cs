using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuarios
    {

        public CD_conexion conexion = new CD_conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public bool Login(string usuario , string contra) {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Login";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contra", contra);

            leer= comando.ExecuteReader();
            tabla.Load(leer);

            conexion.cerrarConexion();

            if (tabla.Rows.Count > 0)
            {
                return true;
            }            
                return false;
            
                
        }




    }
}
