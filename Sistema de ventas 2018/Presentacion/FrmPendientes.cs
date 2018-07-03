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
    }
}
