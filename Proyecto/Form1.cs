using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Proyecto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtPass.Text.Trim(); // Sin encriptación

            using (SqlConnection conn = new SqlConnection("server=SERVIDOR;database=DB_ROKYS; integrated security=true"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT cargo_em FROM TB_EMPLEADO WHERE usuario_em = @usuario AND contrasena_em = @contrasena", conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string cargo = result.ToString();

                        // Crea el formulario Menu y pasa el cargo
                        Menu menu = new Menu(cargo);
                        menu.Show();

                        MessageBox.Show("Bienvenido, " + usuario + "!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide(); // Oculta el formulario de login
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
