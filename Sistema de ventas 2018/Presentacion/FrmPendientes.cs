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
    public partial class FrmPendientes : Form
    {
        public FrmPendientes()
        {
            InitializeComponent();
        }

        private void FrmPendientes_Load(object sender, EventArgs e)
        {
            //una consulta a la base de datos siempre trataremos de omar el control, por si pasa algun error y se cierre la aplicación
            try
            {
                DataSet ds = FIngreso.GetPendientes();//creamos un dataset, un contenedor de datos y hacemos una consulta con la clase FCategoria y su método GetAll
                DataTable dt = ds.Tables[0]; //asignamos los datos del datased a la tabla
                dgvPendientes.DataSource = dt; //propiamente dicho al datagridview le pasamos los datos de la tabla
                dgvPendientes.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvPendientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmSalida salida = new FrmSalida();
            salida.txtBuscarIngreso.Text= dgvPendientes.CurrentRow.Cells["Numero"].Value.ToString();
            salida.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Report frmComprobantes = new Report();
            frmComprobantes.Load(@"Reportes/ReporteIngreso.frx");
            frmComprobantes.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
            frmComprobantes.SetParameterValue("Numero", dgvPendientes.CurrentRow.Cells["Numero"].Value.ToString());
            frmComprobantes.Show();
        }
    }
}
