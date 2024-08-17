namespace Proyecto
{
    partial class Almacen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tapCategoria = new System.Windows.Forms.TabPage();
            this.dgvListado_pr = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio_pr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbMedidas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStock_actual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca_pr = new System.Windows.Forms.TextBox();
            this.txtDescripcion_pr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.tabPrincipal.SuspendLayout();
            this.tapCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado_pr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Green;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Yellow;
            this.btnEliminar.Location = new System.Drawing.Point(333, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 58);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseMnemonic = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Green;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Yellow;
            this.btnSalir.Location = new System.Drawing.Point(628, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 58);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseMnemonic = false;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Green;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Yellow;
            this.btnNuevo.Location = new System.Drawing.Point(55, 376);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 58);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseMnemonic = false;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tapCategoria);
            this.tabPrincipal.Location = new System.Drawing.Point(51, 39);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(701, 316);
            this.tabPrincipal.TabIndex = 19;
            // 
            // tapCategoria
            // 
            this.tapCategoria.Controls.Add(this.dgvListado_pr);
            this.tapCategoria.Controls.Add(this.panel1);
            this.tapCategoria.Controls.Add(this.label2);
            this.tapCategoria.Controls.Add(this.txtBuscar);
            this.tapCategoria.Controls.Add(this.btnBuscar);
            this.tapCategoria.Location = new System.Drawing.Point(4, 22);
            this.tapCategoria.Name = "tapCategoria";
            this.tapCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tapCategoria.Size = new System.Drawing.Size(693, 290);
            this.tapCategoria.TabIndex = 0;
            this.tapCategoria.Text = "Alamancen";
            this.tapCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvListado_pr
            // 
            this.dgvListado_pr.AllowUserToAddRows = false;
            this.dgvListado_pr.AllowUserToDeleteRows = false;
            this.dgvListado_pr.AllowUserToOrderColumns = true;
            this.dgvListado_pr.ColumnHeadersHeight = 35;
            this.dgvListado_pr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListado_pr.Location = new System.Drawing.Point(0, 160);
            this.dgvListado_pr.Name = "dgvListado_pr";
            this.dgvListado_pr.ReadOnly = true;
            this.dgvListado_pr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListado_pr.Size = new System.Drawing.Size(693, 129);
            this.dgvListado_pr.TabIndex = 1;
            this.dgvListado_pr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_pr_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtPrecio_pr);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cmbMedidas);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtStock_actual);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMarca_pr);
            this.panel1.Controls.Add(this.txtDescripcion_pr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCategorias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 116);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(436, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(447, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Precio S/:";
            // 
            // txtPrecio_pr
            // 
            this.txtPrecio_pr.Enabled = false;
            this.txtPrecio_pr.Location = new System.Drawing.Point(539, 87);
            this.txtPrecio_pr.MaxLength = 18;
            this.txtPrecio_pr.Name = "txtPrecio_pr";
            this.txtPrecio_pr.Size = new System.Drawing.Size(82, 20);
            this.txtPrecio_pr.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(8, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(290, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(8, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(290, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "*";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Green;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Yellow;
            this.btnCancelar.Location = new System.Drawing.Point(226, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 28);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseMnemonic = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Yellow;
            this.btnGuardar.Location = new System.Drawing.Point(339, 82);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 28);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseMnemonic = false;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbMedidas
            // 
            this.cmbMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedidas.Enabled = false;
            this.cmbMedidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedidas.FormattingEnabled = true;
            this.cmbMedidas.Location = new System.Drawing.Point(119, 48);
            this.cmbMedidas.Name = "cmbMedidas";
            this.cmbMedidas.Size = new System.Drawing.Size(121, 24);
            this.cmbMedidas.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Medida:";
            // 
            // txtStock_actual
            // 
            this.txtStock_actual.Enabled = false;
            this.txtStock_actual.Location = new System.Drawing.Point(120, 81);
            this.txtStock_actual.MaxLength = 18;
            this.txtStock_actual.Name = "txtStock_actual";
            this.txtStock_actual.Size = new System.Drawing.Size(75, 20);
            this.txtStock_actual.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cantidad:";
            // 
            // txtMarca_pr
            // 
            this.txtMarca_pr.Enabled = false;
            this.txtMarca_pr.Location = new System.Drawing.Point(375, 13);
            this.txtMarca_pr.MaxLength = 30;
            this.txtMarca_pr.Name = "txtMarca_pr";
            this.txtMarca_pr.Size = new System.Drawing.Size(110, 20);
            this.txtMarca_pr.TabIndex = 29;
            // 
            // txtDescripcion_pr
            // 
            this.txtDescripcion_pr.Enabled = false;
            this.txtDescripcion_pr.Location = new System.Drawing.Point(119, 15);
            this.txtDescripcion_pr.MaxLength = 80;
            this.txtDescripcion_pr.Name = "txtDescripcion_pr";
            this.txtDescripcion_pr.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion_pr.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Producto:";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.Enabled = false;
            this.cmbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(412, 48);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 24);
            this.cmbCategorias.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busqueda:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(122, 134);
            this.txtBuscar.MaxLength = 80;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Yellow;
            this.btnBuscar.Location = new System.Drawing.Point(324, 128);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 28);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseMnemonic = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(276, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "ALMACEN ROKY\'S";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Green;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Yellow;
            this.btnModificar.Location = new System.Drawing.Point(199, 376);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 58);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseMnemonic = false;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Green;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Yellow;
            this.btnReporte.Location = new System.Drawing.Point(471, 376);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(109, 58);
            this.btnReporte.TabIndex = 25;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseMnemonic = false;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tabPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tapCategoria.ResumeLayout(false);
            this.tapCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado_pr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tapCategoria;
        private System.Windows.Forms.DataGridView dgvListado_pr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.TextBox txtMarca_pr;
        private System.Windows.Forms.TextBox txtDescripcion_pr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock_actual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbMedidas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecio_pr;
    }
}