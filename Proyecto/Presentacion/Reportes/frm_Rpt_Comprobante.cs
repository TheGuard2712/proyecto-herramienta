﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Presentacion.Reportes
{
    public partial class frm_Rpt_Comprobante : Form
    {
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public decimal Total { get; set; }
        public string Correo { get; set; }
        public frm_Rpt_Comprobante()
        {
            InitializeComponent();
        }

        private void frm_Rpt_Comprobante_Load(object sender, EventArgs e)
        {
            this.uSP_GET_COMPROBANTE_DATATableAdapter.Fill(this.dS_Comprobante.USP_GET_COMPROBANTE_DATA);
            this.reportViewer1.RefreshReport();
        }
    }
}
