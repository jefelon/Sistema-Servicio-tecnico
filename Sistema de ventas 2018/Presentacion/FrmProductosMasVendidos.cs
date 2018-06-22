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
    public partial class FrmProductosMasVendidos : Form
    {
        public FrmProductosMasVendidos()
        {
            InitializeComponent();
        }
        
        private void FrmProductosMasVendidos_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt1 = new DataTable();
                dgvProductosMasVendidos.DataSource = null;
                DataSet ds1 = FVenta.GetProductosMasVendidos(dtpFechaInicio.Value);
                dt1 = ds1.Tables[0];
                dgvProductosMasVendidos.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void buscarFecha(DateTime fecha)
        {
            
        }
           
    }
}
