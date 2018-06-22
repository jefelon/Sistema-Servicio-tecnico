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
    public partial class FrmCompra_Vista : Form
    {
        public FrmCompra_Vista()
        {
            InitializeComponent();
        }

        private void FrmCompra_Vista_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt1 = new DataTable();
                DataSet ds1 = FCompra.GetVista();
                dt1 = ds1.Tables[0];
                dgvDatosCompra.DataSource = dt1;
                dgvDatosCompra.Columns["Id"].Visible = false;
                dgvDatosCompra.Columns["UsuarioId"].Visible = false;
                dgvDatosCompra.Columns["NombreUsuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void BuscarProveedor(int BuscarRuc)
        {
            DataSet ds = FCompra.GetBuscar(BuscarRuc);
            DataTable dt = ds.Tables[0];
            dgvDatosCompra.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCompra form = new FrmCompra();
            form.Show();
        }

        private void dgvDatosCompra_DoubleClick(object sender, EventArgs e)
        {
            FrmCompra form = new FrmCompra();
            form.txtId.Text = dgvDatosCompra.CurrentRow.Cells["Id"].Value.ToString();
            form.Show();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarProveedor(Convert.ToInt32(txtBuscar.Text));
            }           
        }
    }
}
