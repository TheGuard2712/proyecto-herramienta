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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmProducto ventanasa = new frmProducto();
            ventanasa.Show();
            this.Hide();

        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservacion login = new Reservacion();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Almacen login = new Almacen();
            login.Show();
            this.Hide();
        }
    }
}
