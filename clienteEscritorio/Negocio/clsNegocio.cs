using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using clienteEscritorio.ServiceReference1;

namespace clienteEscritorio.Negocio
{
    class clsNegocio
    {
        Service1Client objServicio = new Service1Client();
        private string articulo;
        private string cantidad;
        private int opcion;
        public string Articulo
        {
            get
            {
                return articulo;
            }

            set
            {
                articulo = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public int Opcion
        {
            get
            {
                return opcion;
            }

            set
            {
                opcion = value;
            }
        }

        public DataSet ventasXarticulos()
        {
            DataSet datos = objServicio.ventas_articulo(articulo);
            return datos;
        }

        public DataSet ventasGlobales()
        {
            DataSet datos = objServicio.ventas_globales();
            return datos;
        }

        public DataSet masVendidos()
        {
            DataSet datos = objServicio.articulos_mas_vendidos(cantidad);
            return datos;
        }

        public DataSet existentes()
        {
            DataSet datos = objServicio.productos_existentes();
            return datos;
        }

        public DataSet notificacion()
        {
            DataSet datos = objServicio.notificacion_compra();
            return datos;
        }
    }
}
