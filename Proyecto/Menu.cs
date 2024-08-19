using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proyecto
{
    
    public partial class Menu : Form
    {
        private string cargoUsuario;

        public Menu(string cargo)
        {
            InitializeComponent();
            cargoUsuario = cargo;
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
            Almacen almacen = new Almacen();
            almacen.Show();
            this.Hide();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            if (cargoUsuario == "empleado")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void labelCargo_Click(object sender, EventArgs e)
        {
            labelCargo.Text = cargoUsuario;
        }
    }
}
