using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_ventas_2018.Datos;

namespace Sistema_de_ventas_2018.Presentacion
{
    public partial class FrmListaEquipos : Form
    {
        public FrmListaEquipos()
        {
            InitializeComponent();
        }
        private static DataTable dt = new DataTable();
        public string descripcion;
        public string marca;
        public string modelo;

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FEquipo.GetAll();
                dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
                dgvDatos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            descripcion = dgvDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
            modelo = dgvDatos.CurrentRow.Cells["ModeloId"].Value.ToString();
            marca = dgvDatos.CurrentRow.Cells["MarcaId"].Value.ToString();
            Close();
        }
    }
}
