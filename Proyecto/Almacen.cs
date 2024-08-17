using Proyecto.Datos;
using Proyecto.Entidades;
using Proyecto.Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }
        #region "MIS VARIABLES"
        int nEstadoguarda = 0;
        int vCodigo_pr = 0;
        #endregion

        #region "MIS METODOS"
        private void LimpiaTexto()
        {
            txtDescripcion_pr.Text = "";
            txtMarca_pr.Text = "";
            txtStock_actual.Text = "0.00";
            txtPrecio_pr.Text = "0.00";
            cmbMedidas.Text = "";
            cmbCategorias.Text = "";
        }

        private void EstadoTexto(bool lEstado)
        {
            txtDescripcion_pr.Enabled = lEstado;
            txtMarca_pr.Enabled = lEstado;
            txtStock_actual.Enabled = lEstado;
            cmbMedidas.Enabled = lEstado;
            cmbCategorias.Enabled = lEstado;
            txtPrecio_pr.Enabled = lEstado;
            txtPrecio_pr.Enabled = lEstado;
        }

        private void EstadoBotones(bool lEstado)
        {
            btnCancelar.Visible = !lEstado;
            btnGuardar.Visible = !lEstado;

            btnNuevo.Enabled = lEstado;
            btnModificar.Enabled = lEstado;
            btnEliminar.Enabled = lEstado;
            btnReporte.Enabled = lEstado;
            btnSalir.Enabled = lEstado;

            btnBuscar.Enabled = lEstado;
            txtBuscar.Enabled = lEstado;
            dgvListado_pr.Enabled = lEstado;
        }

        private void Cargar_Medidas()
        {
            D_Productos Datos = new D_Productos();
            cmbMedidas.DataSource = Datos.Listado_me();
            cmbMedidas.ValueMember = "codigo_me";
            cmbMedidas.DisplayMember = "descripcion_me";
        }

        private void Cargar_Categorias()
        {
            D_Productos Datos = new D_Productos();
            cmbCategorias.DataSource = Datos.Listado_ca();
            cmbCategorias.ValueMember = "codigo_ca";
            cmbCategorias.DisplayMember = "descripcion_ca";
        }

        private void Formato_pr()
        {
            dgvListado_pr.Columns[0].Width = 70;
            dgvListado_pr.Columns[0].HeaderText = "CÓDIGO";
            dgvListado_pr.Columns[1].Width = 120;
            dgvListado_pr.Columns[1].HeaderText = "PRODUCTO";
            dgvListado_pr.Columns[2].Width = 100;
            dgvListado_pr.Columns[2].HeaderText = "MARCA";
            dgvListado_pr.Columns[3].Width = 100;
            dgvListado_pr.Columns[3].HeaderText = "MEDIDA";
            dgvListado_pr.Columns[4].Width = 90;
            dgvListado_pr.Columns[4].HeaderText = "CATEGORIA";
            dgvListado_pr.Columns[5].Width = 90;
            dgvListado_pr.Columns[5].HeaderText = "PRECIO S/";
            dgvListado_pr.Columns[6].Width = 90;
            dgvListado_pr.Columns[6].HeaderText = "CANTIDAD";
            dgvListado_pr.Columns[7].Visible = false;
            dgvListado_pr.Columns[8].Visible = false;
        }

        private void Listado_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            dgvListado_pr.DataSource = Datos.Listado_pr(cTexto);
            this.Formato_pr();
        }

        private void Selecciona_Item_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvListado_pr.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("No se tiene información para visdualizar",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.vCodigo_pr= Convert.ToInt32(dgvListado_pr.CurrentRow.Cells["codigo_pr"].Value);
                txtDescripcion_pr.Text = Convert.ToString(dgvListado_pr.CurrentRow.Cells["descripcion_pr"].Value);
                txtMarca_pr.Text = Convert.ToString(dgvListado_pr.CurrentRow.Cells["marca_pr"].Value);
                cmbMedidas.Text = Convert.ToString(dgvListado_pr.CurrentRow.Cells["descripcion_me"].Value);
                cmbCategorias.Text = Convert.ToString(dgvListado_pr.CurrentRow.Cells["descripcion_ca"].Value);
                txtStock_actual.Text = Convert.ToString(dgvListado_pr.CurrentRow.Cells["stock_actual"].Value);
                txtPrecio_pr.Text = Convert.ToString(dgvListado_pr.CurrentRow.Cells["precio_pr"].Value);
            }
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu ventana = new Menu();
            ventana.Show();
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nEstadoguarda = 1;
            this.vCodigo_pr = 0;
            this.LimpiaTexto();
            this.EstadoTexto(true);
            this.EstadoBotones(false);
            txtDescripcion_pr.Select();
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            this.Cargar_Medidas();
            this.Cargar_Categorias();
            this.Listado_pr("%");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiaTexto();
            this.EstadoTexto(false);
            this.EstadoBotones(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_pr.Text == string.Empty ||
                txtMarca_pr.Text == string.Empty ||
                cmbMedidas.Text == string.Empty ||
                cmbCategorias.Text==string.Empty ||
                txtStock_actual.Text==string.Empty ||
                txtPrecio_pr.Text==string.Empty) // validar que todos lo datos estan correctos
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else // proceso para guardar informacion
            {
                string Rpta = "";
                E_Productos oPro = new E_Productos();
                oPro.Codigo_pr = this.vCodigo_pr;
                oPro.Descripcion_pr = txtDescripcion_pr.Text;
                oPro.Marca_pr = txtMarca_pr.Text;
                oPro.Codigo_me = Convert.ToInt32(cmbMedidas.SelectedValue);
                oPro.Codigo_ca = Convert.ToInt32(cmbCategorias.SelectedValue);
                oPro.Stock_actual = Convert.ToDecimal(txtStock_actual.Text);
                oPro.precio_pr = Convert.ToDecimal(txtPrecio_pr.Text);

                D_Productos Datos = new D_Productos();
                Rpta = Datos.Guardar_pr(this.nEstadoguarda,oPro);
                if (Rpta == "OK")
                {
                    this.Listado_pr("%");
                    MessageBox.Show("Los datos han sido guardados correctamente",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.vCodigo_pr = 0;
                    this.LimpiaTexto();
                    this.EstadoTexto(false);
                    this.EstadoBotones(true);
                }
            }
        }

        private void dgvListado_pr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_pr();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.nEstadoguarda = 2; // Actualizar registro
            this.EstadoTexto(true);
            this.EstadoBotones(false);
            txtDescripcion_pr.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_pr(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListado_pr.Rows.Count <= 0 ||
                (string.IsNullOrEmpty(Convert.ToString(dgvListado_pr.CurrentRow.Cells["codigo_pr"].Value))))
            {
                MessageBox.Show("No se tiene información para eliminar",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                string Rpta = "";
                D_Productos Datos = new D_Productos();
                Rpta = Datos.Activo_pr(vCodigo_pr,false);
                if (Rpta=="OK")
                {
                    this.Listado_pr("%");
                    this.LimpiaTexto();
                    vCodigo_pr = 0;
                    MessageBox.Show("EL registro seleccionado ha sido eliminado",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Frm_Rpt_Listado_pr oFrm_rpt = new Frm_Rpt_Listado_pr();
            oFrm_rpt.txt_01.Text = txtBuscar.Text;
            oFrm_rpt.ShowDialog();
        }
    }
}
