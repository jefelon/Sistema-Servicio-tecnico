using FastReport;
using Sistema_de_ventas_2018.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_2018.Presentacion
{
    public partial class FrmKardex : Form
    {
        public FrmKardex()
        {
            InitializeComponent();
        }

        private void FrmKardex_Load(object sender, EventArgs e)
        {
            DataSet ds = FProducto.GetAll();
            DataTable dt0 = ds.Tables[0];
            dgvDatos.DataSource = dt0;
            dgvDatos.Columns["Id"].Visible = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Report frmComprobantes = new Report();
            frmComprobantes.Load(@"Reportes/ReporteKardex.frx");
            frmComprobantes.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
            frmComprobantes.SetParameterValue("ProductoId", Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString()));

            frmComprobantes.Show();
        }
    }
}
