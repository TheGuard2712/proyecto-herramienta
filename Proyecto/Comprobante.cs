using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Comprobante : Form
    {
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

        }

        private void Comprobante_Load(object sender, EventArgs e)
        {

        }
    }
}
