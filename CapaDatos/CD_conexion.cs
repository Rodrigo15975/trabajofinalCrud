using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class CD_conexion
    {
        private SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-QF75754\\SQLEXPRESS; Database=Practica; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            
            return conexion;
       
        }
        public SqlConnection cerrarConexion()
        {
        
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
                return conexion;
        
        }




    }
}
