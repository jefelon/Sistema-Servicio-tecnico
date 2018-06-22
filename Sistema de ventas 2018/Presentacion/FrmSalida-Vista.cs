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
    public partial class FrmSalida_Vista : Form
    {
        public FrmSalida_Vista()
        {
            InitializeComponent();
        }
        DataTable dt1 = new DataTable();
        private void FrmSalida_Vista_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FSalida.GetAll();
                dt1 = ds.Tables[0];
                dgvListaSalida.DataSource = dt1;
                dgvListaSalida.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvListaSalida_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FrmDetalleProductoSalida datossalida = new FrmDetalleProductoSalida();
                foreach (Form win in Application.OpenForms)
                {
                    if (win.Name == "FrmDetalleProductoSalida")
                    {
                        datossalida = (FrmDetalleProductoSalida)win;
                        //FrmVenta datosProducto = new FrmVenta();
                        datossalida.txtSalidaId.Text = dgvListaSalida.CurrentRow.Cells[0].Value.ToString();

                        datossalida.Show();
                        this.Close();
                        break;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                FrmDetalleServicioSalida datossalida = new FrmDetalleServicioSalida();
                foreach (Form win in Application.OpenForms)
                {
                    if (win.Name == "FrmDetalleServicioSalida")
                    {
                        datossalida = (FrmDetalleServicioSalida)win;
                        //FrmVenta datosProducto = new FrmVenta();
                        datossalida.txtSalidaId.Text = dgvListaSalida.CurrentRow.Cells[0].Value.ToString();
                        datossalida.Show();
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

        private void dgvListaSalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaSalida.CurrentRow != null)
            {
                dgvListaSalida.CurrentRow.Cells["Id"].Value.ToString();
                dgvListaSalida.CurrentRow.Cells["Numero"].Value.ToString();
                dgvListaSalida.CurrentRow.Cells["FechaSalida"].Value.ToString();
                dgvListaSalida.CurrentRow.Cells["Diagnostico"].Value.ToString();
                dgvListaSalida.CurrentRow.Cells["Estado"].Value.ToString();
            }
        }
    }
}
