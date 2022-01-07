using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clienteEscritorio.Negocio;

namespace clienteEscritorio.Usuario
{
    public partial class frmPantalla : Form
    {
        public frmPantalla()
        {
            InitializeComponent();
        }

        private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsNegocio objNegocio = new clsNegocio();
            objNegocio.Articulo = txtArticulo.Text;
            objNegocio.Cantidad = nudCantidad.Value.ToString();
            objNegocio.Opcion = cmbOpciones.SelectedIndex;
            DataSet datos;
            if (objNegocio.Opcion == 0)
            {
                datos = objNegocio.ventasXarticulos();
                dataGridViewPrincipal.DataSource = datos.Tables[0];
                alertas();
            }

            if (objNegocio.Opcion == 1)
            {
                datos = objNegocio.ventasGlobales();
                dataGridViewPrincipal.DataSource = datos.Tables[0];
                alertas();
            }

            if (objNegocio.Opcion == 2)
            {
                datos = objNegocio.masVendidos();
                dataGridViewPrincipal.DataSource = datos.Tables[0];
                alertas();
            }

            if (objNegocio.Opcion == 3)
            {
                datos = objNegocio.existentes();
                dataGridViewPrincipal.DataSource = datos.Tables[0];
                alertas();
            }
        }

        private void frmPantalla_Load(object sender, EventArgs e)
        {
            alertas();
        }

        public void alertas()
        {
            clsNegocio objNegocio = new clsNegocio();
            DataSet datos;
            datos = objNegocio.notificacion();
            dataGridViewAlertas.DataSource = datos.Tables[0];

            if (datos.Tables[0].Rows.Count > 0)
            {
                // tiene filas
                lblMensajeUno.Visible = true;
                lblMensajeDos.Visible = true;
                dataGridViewAlertas.Visible = true;
            }
            else
            {
                // está vacío
                lblMensajeUno.Visible = false;
                lblMensajeDos.Visible = false;
                dataGridViewAlertas.Visible = false;
            }   
        }
    }
}
