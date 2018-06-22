using Sistema_de_ventas_2018.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_2018.Presentacion
{
    public partial class FrmVenta_Vista : Form
    {
        public FrmVenta_Vista()
        {
            InitializeComponent();
        }
        DataTable dt1 = new DataTable();
        private void FrmVenta_Vista_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FVenta.GetVista();
                dt1 = ds.Tables[0];
                dgvDatosVenta.DataSource = dt1;
                dgvDatosVenta.Columns["Id"].Visible = false;
                dgvDatosVenta.Columns["UsuarioId"].Visible = false;
                dgvDatosVenta.Columns["NombreUsuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void cargarDatosVentaCliente(int BuscarDni)
        {
            DataSet ds = FVenta.GetBuscar(BuscarDni);
            DataTable dt = ds.Tables[0];
            dgvDatosVenta.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmVenta form = new FrmVenta();
            form.Show();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cargarDatosVentaCliente(Convert.ToInt32(txtBuscar.Text));
            }
        }

        private void dgvDatosVenta_DoubleClick(object sender, EventArgs e)
        {
            FrmVenta form = new FrmVenta();
           form.txtId.Text= dgvDatosVenta.CurrentRow.Cells["Id"].Value.ToString();
            form.Show();
        }
    }
}
