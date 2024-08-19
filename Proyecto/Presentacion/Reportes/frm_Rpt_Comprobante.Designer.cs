namespace Proyecto.Presentacion.Reportes
{
    partial class frm_Rpt_Comprobante
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Comprobante = new Proyecto.Presentacion.Reportes.DS_Comprobante();
            this.uSPGETCOMPROBANTEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GET_COMPROBANTE_DATATableAdapter = new Proyecto.Presentacion.Reportes.DS_ComprobanteTableAdapters.USP_GET_COMPROBANTE_DATATableAdapter();
            this.txt02 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Comprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGETCOMPROBANTEDATABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPGETCOMPROBANTEDATABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Reportes.Rpt_Comprobante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Comprobante
            // 
            this.dS_Comprobante.DataSetName = "DS_Comprobante";
            this.dS_Comprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPGETCOMPROBANTEDATABindingSource
            // 
            this.uSPGETCOMPROBANTEDATABindingSource.DataMember = "USP_GET_COMPROBANTE_DATA";
            this.uSPGETCOMPROBANTEDATABindingSource.DataSource = this.dS_Comprobante;
            // 
            // uSP_GET_COMPROBANTE_DATATableAdapter
            // 
            this.uSP_GET_COMPROBANTE_DATATableAdapter.ClearBeforeFill = true;
            // 
            // txt02
            // 
            this.txt02.Location = new System.Drawing.Point(23, 33);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(104, 20);
            this.txt02.TabIndex = 1;
            // 
            // frm_Rpt_Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Rpt_Comprobante";
            this.Text = "frm_Rpt_Comprobante";
            this.Load += new System.EventHandler(this.frm_Rpt_Comprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Comprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGETCOMPROBANTEDATABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Comprobante dS_Comprobante;
        private System.Windows.Forms.BindingSource uSPGETCOMPROBANTEDATABindingSource;
        private DS_ComprobanteTableAdapters.USP_GET_COMPROBANTE_DATATableAdapter uSP_GET_COMPROBANTE_DATATableAdapter;
        internal System.Windows.Forms.TextBox txt02;
    }
}