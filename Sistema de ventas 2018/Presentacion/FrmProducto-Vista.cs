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
    public partial class FrmProducto_Vista : Form
    {
        public FrmProducto_Vista()
        {
            InitializeComponent();
        }

        public int idDetalle;
        public string precio, descripcion, productoId;
        DataTable dt = new DataTable();

        private void FrmProducto_Vista_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FProducto.GetAll();
                dt = ds.Tables[0];
                dgvDatosProducto.DataSource = dt;
                dgvDatosProducto.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cargarProducto(string BuscarNombre)
        {
            DataSet ds = FProducto.GetBuscar(BuscarNombre);
            DataTable dt = ds.Tables[0];
            dgvDatosProducto.DataSource = dt;
        }

        private void txtBuscarNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cargarProducto((txtBuscarNombre.Text));
            }
        }


        private void dgvDatos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                productoId = dgvDatosProducto.CurrentRow.Cells["Id"].Value.ToString();
                descripcion = dgvDatosProducto.CurrentRow.Cells["Nombre"].Value.ToString();
                precio = dgvDatosProducto.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
