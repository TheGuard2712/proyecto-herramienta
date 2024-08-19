using Microsoft.Reporting.Map.WebForms.BingMaps;
using Proyecto.Datos;
using Proyecto.Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto.Datos.D_Productos;

namespace Proyecto
{
    public partial class Comprobante : Form
    {
        private const decimal IGVPeru = 0.18m;
        private DataSet DS_Comprobante = new DataSet();
        public Comprobante()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmProducto ventana = new frmProducto();
            ventana.Show();
            this.Hide();
        }

        public decimal Total
        {
            get { return decimal.Parse(txtTotal.Text); }
            set { txtTotal.Text = value.ToString("0.00"); }
        }

        private void btnEnviarPedido_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show("Comprobante impreso correctamente.");

        }

        private void Comprobante_Load(object sender, EventArgs e)
        {
            txtIgv.Text = IGVPeru.ToString("P0");
            CalcularTotalConIGV();
        }

        private void CalcularTotalConIGV()
        {
            decimal montoBase;
            if (decimal.TryParse(txtTotal.Text, out montoBase))
            {
                decimal igvCalculado = montoBase * IGVPeru;
                decimal totalConIGV = montoBase + igvCalculado;

                // Mostrar el total calculado en el TextBox de Total
                txtTotal.Text = totalConIGV.ToString("0.00");
            }
            
        }

        private void CargarDatosComprobante(int codComprobante)
        {

            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtRuc.Enabled = false;
            txtRazon_social.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtRuc.Enabled = true;
            txtRazon_social.Enabled = true;
        }
    }
}


