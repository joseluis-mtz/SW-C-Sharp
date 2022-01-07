using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace servicioPrueba
{
    public class Service1 : IService1
    {
        clsConexion objConexion = new clsConexion();
        public DataSet ventas_articulo(string articulo)
        {
            string sql = "select Titulo as [Título], Descripcion as [Descripción], CantidadVendida as [Cantidad vendida] from Productos INNER JOIN Ventas ON Productos.IDProductos = Ventas.IDVentas where Titulo Like '%" + articulo + "%'";
            DataSet datos = objConexion.consultar(sql, "Productos");
            return datos;
        }

        public DataSet ventas_globales()
        {
            string sql = "select Titulo as [Título], Descripcion as [Descripción], CantidadVendida as [Cantidad vendida] from Productos INNER JOIN Ventas ON Productos.IDProductos = Ventas.IDVentas";
            DataSet datos = objConexion.consultar(sql, "Productos");
            return datos;
        }

        public DataSet articulos_mas_vendidos(string numero)
        {
            string sql = "select top " + numero + " Titulo as [Título], Descripcion as [Descripción], CantidadVendida as [Cantidad vendida] from Productos INNER JOIN Ventas ON Productos.IDProductos = Ventas.IDVentas Order By CantidadVendida DESC";
            DataSet datos = objConexion.consultar(sql, "Productos");
            return datos;
        }

        public DataSet productos_existentes()
        {
            string sql = "select Titulo, Descripcion, Existencias from Productos where Existencias > 0";
            DataSet datos = objConexion.consultar(sql, "Productos");
            return datos;
        }

        public DataSet notificacion_compra()
        {
            string sql = "select Titulo, Existencias from Productos where Existencias < 100";
            DataSet datos = objConexion.consultar(sql, "Productos");
            return datos;
        }
    }
}
