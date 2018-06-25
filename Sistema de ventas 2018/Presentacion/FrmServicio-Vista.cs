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
    public partial class FrmServicio_Vista : Form
    {
        public FrmServicio_Vista()
        {
            InitializeComponent();
        }
        DataTable dt1 = new DataTable();
        public string precio, descripcion, servicioId;//variables que se utilizan en el FrmDetalleServicioSalida
        private void FrmServicio_Vista_Load(object sender, EventArgs e)
        {
            DataSet ds = FServicio.GetAll();//creamos un datased, un contenedor de datos hacemos una consulta a la clace FServicio y su metodo GetAll, en ella el SalidaId
            dt1 = ds.Tables[0];//asignamos los datos del datased a la tabla
            dgvServicioLista.DataSource = dt1;//pasamos los datos de la tabla al datagridview
            dgvServicioLista.Columns["Id"].Visible = false;
        }

        private void dgvServicioLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvServicioLista.CurrentRow.Cells["Id"].Value.ToString();//asignamos los datos a datagridview
            dgvServicioLista.CurrentRow.Cells["Descripcion"].Value.ToString(); //asignamos los datos a datagridview
            dgvServicioLista.CurrentRow.Cells["Precio"].Value.ToString();
        }

        

        private void dgvServicioLista_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                servicioId= precio = dgvServicioLista.CurrentRow.Cells["Id"].Value.ToString();//validamos los datos para pasar los datos a otro formulario
                precio = dgvServicioLista.CurrentRow.Cells["Precio"].Value.ToString();//validamos los datos para pasar los datos a otro formulario
                descripcion = dgvServicioLista.CurrentRow.Cells["Descripcion"].Value.ToString();
                Close();//cerramos el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
