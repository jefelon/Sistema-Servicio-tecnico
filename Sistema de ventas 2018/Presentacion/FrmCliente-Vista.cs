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
    public partial class FrmCliente_Vista : Form
    {
        public FrmCliente_Vista()
        {
            InitializeComponent();
        }
        private static DataTable dt = new DataTable();

        public string nombre;
        public string apellido_paterno;
        public string dni;
        public string direccion;
        private void FrmCliente_Vista_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FCliente.GetAll();
                dt = ds.Tables[0];
                dgvListaCliente.DataSource = dt;
                dgvListaCliente.Columns["Id"].Visible = false;    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvListaCliente.CurrentRow != null)
            {
                dgvListaCliente.CurrentRow.Cells["Id"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Tipo_doc"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Ruc"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Dni"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Numero_doc"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Razon_social"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Email"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Celular"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                dgvListaCliente.CurrentRow.Cells["FechaRegistro"].Value.ToString();
            }

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                FrmIngreso datosCliente = new FrmIngreso();
                foreach (Form win in Application.OpenForms)
                {
                    if (win.Name == "FrmIngreso")
                    {
                        datosCliente = (FrmIngreso)win;
                        //FrmVenta datosProducto = new FrmVenta();
                        datosCliente.txtClienteId.Text = dgvListaCliente.CurrentRow.Cells[0].Value.ToString();
                        datosCliente.txtNombre.Text = dgvListaCliente.CurrentRow.Cells[6].Value.ToString()+" "+ dgvListaCliente.CurrentRow.Cells[7].Value.ToString()+" "+dgvListaCliente.CurrentRow.Cells[8].Value.ToString();
                        datosCliente.txtDNI.Text = dgvListaCliente.CurrentRow.Cells[3].Value.ToString();
                        datosCliente.txtDireccion.Text = dgvListaCliente.CurrentRow.Cells[12].Value.ToString();
                        //0,6 7 8,3,12
                        datosCliente.Show();
                        this.Close();
                        break;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
