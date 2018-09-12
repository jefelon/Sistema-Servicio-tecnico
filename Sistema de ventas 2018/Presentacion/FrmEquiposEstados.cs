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
    public partial class FrmEquiposEstados : Form
    {
        public FrmEquiposEstados()
        {
            InitializeComponent();
        }

        private void FrmEquiposEstados_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void cargar()
        {
            try
            {
                DataSet ds = FSalida.GetEstados(dtpDesde.Value, dtpHasta.Value, cmbEstado.Text);//creamos un dataset, un contenedor de datos y hacemos una consulta con la clase FCategoria y su método GetAll
                DataTable dt = ds.Tables[0]; //asignamos los datos del datased a la tabla
                dgvPendientes.DataSource = dt; //propiamente dicho al datagridview le pasamos los datos de la tabla
                dgvPendientes.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            cargar();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            cargar();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
