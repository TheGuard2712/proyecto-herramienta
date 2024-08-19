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
        private string cargoUsuario;
        public Reservacion()
        {
            InitializeComponent();
        }

        private void Reservacion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu ventana = new Menu(cargoUsuario);
            ventana.Show();
            this.Hide();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string cantidadPersonas = cmbCantidadPersona.SelectedItem.ToString();
            string fechaHora = txtFecha.Text;
            string correoElectronico = txtCorreo.Text;

            // Generar el código de reservación
            string codigoReservacion = GenerarCodigoReservacion();

            // Mostrar el mensaje de confirmación
            MessageBox.Show($"¡Reserva confirmada!\n\nCódigo de reservación: {codigoReservacion}\n\nSe ha enviado la confirmación a: {correoElectronico}",
                            "Confirmación de Reservación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Comprobante ventana = new Comprobante();
            ventana.Show();
            this.Hide();
        }

        private void cmbCantidadPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string GenerarCodigoReservacion()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
