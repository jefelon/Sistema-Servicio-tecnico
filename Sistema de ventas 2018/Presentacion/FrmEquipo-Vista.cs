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
    public partial class FrmEquipo_Vista : Form
    {
        public FrmEquipo_Vista()
        {
            InitializeComponent();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaEquipo.CurrentRow != null)
            {
                dgvListaEquipo.CurrentRow.Cells["Id"].Value.ToString();
                dgvListaEquipo.CurrentRow.Cells["Descripcion"].Value.ToString();
                dgvListaEquipo.CurrentRow.Cells["Modelo"].Value.ToString();
                dgvListaEquipo.CurrentRow.Cells["Serie"].Value.ToString();
            }
        }
        DataTable dt1 = new DataTable();
        private void FrmEquipo_Vista_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FEquipo.GetAll();
                dt1 = ds.Tables[0];
                dgvListaEquipo.DataSource = dt1;
                dgvListaEquipo.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvListaEquipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmIngreso datosEquipo = new FrmIngreso();
                foreach (Form win in Application.OpenForms)
                {
                    if (win.Name == "FrmIngreso")
                    {
                        datosEquipo = (FrmIngreso)win;
                        //FrmVenta datosProducto = new FrmVenta();
                        datosEquipo.txtEquipoId.Text = dgvListaEquipo.CurrentRow.Cells[0].Value.ToString();
                        datosEquipo.txtDescripcion.Text = dgvListaEquipo.CurrentRow.Cells[1].Value.ToString();
                        datosEquipo.txtMarca.Text = dgvListaEquipo.CurrentRow.Cells[4].Value.ToString();
                        datosEquipo.txtModelo.Text = dgvListaEquipo.CurrentRow.Cells[3].Value.ToString();

                        datosEquipo.Show();
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
