namespace Proyecto
{
    partial class frmProducto
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tapCategoria = new System.Windows.Forms.TabPage();
            this.dgvListado_pr2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dS_Reportes = new Proyecto.Presentacion.Reportes.DS_Reportes();
            this.uSPLISTADOPRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_LISTADO_PRTableAdapter = new Proyecto.Presentacion.Reportes.DS_ReportesTableAdapters.USP_LISTADO_PRTableAdapter();
            this.tapCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado_pr2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPLISTADOPRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(241, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "MENU ROKY\'S";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Green;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Yellow;
            this.btnSalir.Location = new System.Drawing.Point(562, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 58);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseMnemonic = false;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Yellow;
            this.btnAgregar.Location = new System.Drawing.Point(22, 406);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 58);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Enviar";
            this.btnAgregar.UseMnemonic = false;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tapCategoria
            // 
            this.tapCategoria.Controls.Add(this.dgvListado_pr2);
            this.tapCategoria.Controls.Add(this.panel1);
            this.tapCategoria.Location = new System.Drawing.Point(4, 22);
            this.tapCategoria.Name = "tapCategoria";
            this.tapCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tapCategoria.Size = new System.Drawing.Size(710, 292);
            this.tapCategoria.TabIndex = 0;
            this.tapCategoria.Text = "Producto";
            this.tapCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvListado_pr2
            // 
            this.dgvListado_pr2.AllowUserToAddRows = false;
            this.dgvListado_pr2.AllowUserToDeleteRows = false;
            this.dgvListado_pr2.AllowUserToOrderColumns = true;
            this.dgvListado_pr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado_pr2.Location = new System.Drawing.Point(6, 67);
            this.dgvListado_pr2.Name = "dgvListado_pr2";
            this.dgvListado_pr2.ReadOnly = true;
            this.dgvListado_pr2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado_pr2.Size = new System.Drawing.Size(693, 219);
            this.dgvListado_pr2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnBuscar2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbProductos);
            this.panel1.Controls.Add(this.txtBuscar2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.Green;
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar2.ForeColor = System.Drawing.Color.Yellow;
            this.btnBuscar2.Location = new System.Drawing.Point(592, 12);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(78, 31);
            this.btnBuscar2.TabIndex = 20;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseMnemonic = false;
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categorias:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(419, 16);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(157, 21);
            this.cmbProductos.TabIndex = 2;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Location = new System.Drawing.Point(104, 18);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(188, 20);
            this.txtBuscar2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busqueda:";
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tapCategoria);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 67);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(718, 318);
            this.tabPrincipal.TabIndex = 13;
            // 
            // btnAumentar
            // 
            this.btnAumentar.BackColor = System.Drawing.Color.Green;
            this.btnAumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.ForeColor = System.Drawing.Color.Yellow;
            this.btnAumentar.Location = new System.Drawing.Point(199, 406);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(149, 58);
            this.btnAumentar.TabIndex = 18;
            this.btnAumentar.Text = " Aumentar +";
            this.btnAumentar.UseMnemonic = false;
            this.btnAumentar.UseVisualStyleBackColor = false;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.BackColor = System.Drawing.Color.Green;
            this.btnDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisminuir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.ForeColor = System.Drawing.Color.Yellow;
            this.btnDisminuir.Location = new System.Drawing.Point(384, 406);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(156, 58);
            this.btnDisminuir.TabIndex = 18;
            this.btnDisminuir.Text = "Disminuir -";
            this.btnDisminuir.UseMnemonic = false;
            this.btnDisminuir.UseVisualStyleBackColor = false;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPLISTADOPRBindingSource
            // 
            this.uSPLISTADOPRBindingSource.DataMember = "USP_LISTADO_PR";
            this.uSPLISTADOPRBindingSource.DataSource = this.dS_Reportes;
            // 
            // uSP_LISTADO_PRTableAdapter
            // 
            this.uSP_LISTADO_PRTableAdapter.ClearBeforeFill = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisminuir);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.tapCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado_pr2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPLISTADOPRBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabPage tapCategoria;
        private System.Windows.Forms.DataGridView dgvListado_pr2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar2;
        private Presentacion.Reportes.DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource uSPLISTADOPRBindingSource;
        private Presentacion.Reportes.DS_ReportesTableAdapters.USP_LISTADO_PRTableAdapter uSP_LISTADO_PRTableAdapter;
    }
}