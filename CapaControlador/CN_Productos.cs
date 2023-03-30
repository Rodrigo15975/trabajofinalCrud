using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class CN_Productos
    {
        private CD_productos objetoCD = new CD_productos();

        public DataTable mostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar();
            return tabla;
        }

        public void insertarProductos(string nombre, string desc, string marca, string precio, string stock)
        {
            objetoCD.insertarProducto(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void actualizarProductos(string nombre, string desc, string marca, string precio, string stock, string id){
            objetoCD.actualizarProducto(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void eliminarProducto(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
