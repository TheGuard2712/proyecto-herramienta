using Proyecto.Datos;
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

namespace Proyecto
{
    public partial class frmProducto : Form
    {
        
        public frmProducto()
        {
            InitializeComponent();

            
        }
        #region "MIS METODOS"
        private void Cargar_Categorias()
        {
            D_Productos Datos = new D_Productos();
            cmbProductos.DataSource = Datos.Listado_ca();
            cmbProductos.ValueMember = "codigo_ca";
            cmbProductos.DisplayMember = "descripcion_ca";
        }


        private void Actualizar_Stock_Producto(bool esAumento)
        {
            if (dgvListado_pr2.SelectedRows.Count > 0)
            {
                int codigo_pr = Convert.ToInt32(dgvListado_pr2.CurrentRow.Cells["codigo_pr"].Value);
                decimal cantidad = 1;

                // Definir e inicializar la variable precio
                decimal precio = 0;
                if (dgvListado_pr2.CurrentRow.Cells["precio_pr"].Value != DBNull.Value)
                {
                    precio = Convert.ToDecimal(dgvListado_pr2.CurrentRow.Cells["precio_pr"].Value);
                }

                D_Productos Datos = new D_Productos();
                string Rpta = Datos.Actualizar_Stock(codigo_pr, cantidad, esAumento, precio);

                if (Rpta == "OK")
                {
                    MessageBox.Show("El stock ha sido actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void Formato_pr()
        {

            dgvListado_pr2.Columns[0].Width = 70;
            dgvListado_pr2.Columns[0].HeaderText = "CÓDIGO";
            dgvListado_pr2.Columns[1].Width = 120;
            dgvListado_pr2.Columns[1].HeaderText = "PRODUCTO";
            dgvListado_pr2.Columns[2].Width = 100;
            dgvListado_pr2.Columns[2].HeaderText = "MARCA";
            dgvListado_pr2.Columns[3].Width = 100;
            dgvListado_pr2.Columns[3].HeaderText = "MEDIDA";
            dgvListado_pr2.Columns[4].Width = 90;
            dgvListado_pr2.Columns[4].HeaderText = "CATEGORIA";
            dgvListado_pr2.Columns[5].Width = 90;
            dgvListado_pr2.Columns[5].HeaderText = "PRECIO S/";
            dgvListado_pr2.Columns[6].Width = 90;
            dgvListado_pr2.Columns[6].HeaderText = "CANTIDAD";
            dgvListado_pr2.Columns[7].Visible = false;
            dgvListado_pr2.Columns[8].Visible = false;
        }

        private void Listado_pr2(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            dgvListado_pr2.DataSource = Datos.Listado_pr(cTexto);
            this.Formato_pr();
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {   
            Menu ventana = new Menu();
            ventana.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Comprobante ventana = new Comprobante();
            ventana.Show();
            this.Hide();

            
            Comprobante comprobante = new Comprobante();

            
            decimal total = 0;
            foreach (DataGridViewRow row in dgvListado_pr2.SelectedRows)
            {
                
                decimal precio = Convert.ToDecimal(row.Cells["precio_pr"].Value);
                total += precio;
            }

            
            comprobante.Total = total;

            
            comprobante.Show();
        }

        

        private void frmProducto_Load(object sender, EventArgs e)
        {
            this.Cargar_Categorias();
            this.Listado_pr2("%");
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            D_Productos Datos = new D_Productos();
            dgvListado_pr2.DataSource = Datos.Listado_pr_por_Categoria(cmbProductos.Text);

            if (cmbProductos.SelectedItem == null)
            {
                string categoriaSeleccionada = cmbProductos.SelectedItem.ToString();
                D_Productos datosProductos = new D_Productos();
                DataTable productosPorCategoria = datosProductos.Listado_pr_por_Categoria(categoriaSeleccionada);

                // Verificar si la tabla tiene filas
                if (productosPorCategoria.Rows.Count > 0)
                {
                    dgvListado_pr2.DataSource = productosPorCategoria;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para esta categoría.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvListado_pr2.DataSource = null;
                }
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (dgvListado_pr2.SelectedRows.Count > 0)
            {
                // Obtener los valores seleccionados en el DataGridViewint
                int codigoProducto = Convert.ToInt32(dgvListado_pr2.SelectedRows[0].Cells["codigo_pr"].Value);
                decimal cantidadActual = Convert.ToDecimal(dgvListado_pr2.SelectedRows[0].Cells["stock_actual"].Value);
                decimal precioProducto = Convert.ToDecimal(dgvListado_pr2.SelectedRows[0].Cells["precio_pr"].Value);
                decimal cantidadAumentar = 1; // Cantidad a aumentar// Aumentar la cantidad en el DataGridView
                dgvListado_pr2.SelectedRows[0].Cells["stock_actual"].Value = cantidadActual + cantidadAumentar;

                // Actualizar la cantidad en la base de datos
                D_Productos datosProductos = new D_Productos();
                string respuesta = datosProductos.Actualizar_Stock(codigoProducto, cantidadAumentar,true, precioProducto); // true indica aumento
                if (respuesta == "OK")
                {
                    MessageBox.Show("Cantidad aumentada correctamente en el almacén.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al aumentar la cantidad en el almacén: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para aumentar la cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (dgvListado_pr2.SelectedRows.Count > 0)
            {
                int codigoProducto = Convert.ToInt32(dgvListado_pr2.SelectedRows[0].Cells["codigo_pr"].Value);
                decimal cantidadActual = Convert.ToDecimal(dgvListado_pr2.SelectedRows[0].Cells["stock_actual"].Value);
                decimal precioProducto = Convert.ToDecimal(dgvListado_pr2.SelectedRows[0].Cells["precio_pr"].Value);
                decimal cantidadDisminuir = 1; // Cantidad a disminuir

                if (cantidadActual >= cantidadDisminuir)
                {
                    // Disminuir la cantidad en el DataGridView
                    dgvListado_pr2.SelectedRows[0].Cells["stock_actual"].Value = cantidadActual - cantidadDisminuir;

                    // Actualizar la cantidad en la base de datos
                    D_Productos datosProductos = new D_Productos();
                    string respuesta = datosProductos.Actualizar_Stock(codigoProducto, cantidadDisminuir, false, precioProducto); // false indica disminución

                    if (respuesta == "OK")
                    {
                        MessageBox.Show("Cantidad disminuida correctamente en el almacén.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refrescar el DataGridView para asegurar que los datos sean los más recientes
                        this.Listado_pr2("%");
                    }
                    else
                    {
                        MessageBox.Show("Error al disminuir la cantidad en el almacén: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No puedes disminuir la cantidad por debajo de 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para disminuir la cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
