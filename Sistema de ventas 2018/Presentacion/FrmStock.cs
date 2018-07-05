using Sistema_de_ventas_2018.Datos;
using Sistema_de_ventas_2018.Negocio;
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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            FrmProducto_Vista form = new FrmProducto_Vista();
            form.ShowDialog();
            txtProductoId.Text = form.productoId;
            txtProducto.Text = form.descripcion;
        }
        DataTable dt1 = new DataTable();
        private void FrmStock_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);

                DataSet ds1 = FStock.GetAll();
                dt1 = ds1.Tables[0];
                dgvDatos.DataSource = dt1;
                dgvDatos.Columns["Id"].Visible = false;
                dgvDatos.Columns["ProductoId"].Visible = false;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    if (txtId.Text == "")
                    {
                        Stock stock = new Stock();
                        stock.Producto.Id= Convert.ToInt32(txtProductoId.Text);
                        stock.CantidadStock = Convert.ToInt32(txtStock.Text);
                        int returnId = FStock.Insertar(stock);
                        if (returnId > 0)
                        {
                            FrmStock_Load(null, null);
                        }
                    }
                    else
                    {
                        Stock stock = new Stock();
                        stock.Id = Convert.ToInt32(txtId.Text);
                        stock.Producto.Id = Convert.ToInt32(txtProductoId.Text);
                        stock.CantidadStock = Convert.ToInt32(txtStock.Text);
                        int returnId = FStock.Actualizar(stock);
                        if (returnId > 0)
                        {
                            FrmStock_Load(null, null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                }
            
        }
        public string validarDatos()
        {
            string resultado = "";
            if (txtStock.Text == "")
            {
                resultado = "El campor Stock está vacío";
                txtStock.Focus();
            }
            if (txtProducto.Text == "")
            {
                resultado = "Falta Cargar Producto";
                txtProducto.Focus();
            }
            return resultado;
        }
        public void mostrarOcultar(bool b)
        {
            txtProducto.Enabled = b;
            txtStock.Enabled = b;
            btnCargarProducto.Enabled = b;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtProducto.Text = "";
            txtProductoId.Text = "";
            txtStock.Text = "";
            mostrarOcultar(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mostrarOcultar(true);
        }
        public void asignarDatos()
        {
            if (dgvDatos.CurrentRow != null)
            {
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtProductoId.Text = dgvDatos.CurrentRow.Cells["ProductoId"].Value.ToString();
                txtProducto.Text = dgvDatos.CurrentRow.Cells["NombreProducto"].Value.ToString();
                txtStock.Text = dgvDatos.CurrentRow.Cells["Stock"].Value.ToString();                
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            asignarDatos();
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            asignarDatos();
        }
    }
}
