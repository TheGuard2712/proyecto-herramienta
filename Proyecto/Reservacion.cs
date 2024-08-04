using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace Proyecto
{
    public partial class Reservacion : Form
    {
        public Reservacion()
        {
            InitializeComponent();
        }

        private void Reservacion_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu ventana = new Menu();
            ventana.Show();
            this.Hide();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Comprobante ventana = new Comprobante();
            ventana.Show();
            this.Hide();
        }

        private void cmbCantidadPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
