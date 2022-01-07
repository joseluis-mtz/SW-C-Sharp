using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clienteWeb.ServiceReference1;
namespace clienteWeb
{
    public partial class frmWebPantalla : System.Web.UI.Page
    {
        ServiceReference1.Service1Client objServicio = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            alertas();
        }

        public void alertas()
        {

            GridView2.DataSource = objServicio.notificacion_compra();
            GridView2.DataBind();

            if (GridView2.Rows.Count > 0)
            {
                // tiene filas
                lblAlerta.Visible = true;
                GridView2.Visible = true;
            }
            else
            {
                lblAlerta.Visible = false;
                GridView2.Visible = false;
            }
        }

        protected void btnVentasArticulo_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = objServicio.ventas_articulo(txtArticulo.Text);
            GridView1.DataBind();
            alertas();
        }

        protected void btnVGlobales_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = objServicio.ventas_globales();
            GridView1.DataBind();
            alertas();
        }

        protected void btnMasVendidos_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = objServicio.articulos_mas_vendidos(txtCantidad.Text);
            GridView1.DataBind();
            alertas();
        }

        protected void btnExistentes_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = objServicio.productos_existentes();
            GridView1.DataBind();
            alertas();
        }
    }
}