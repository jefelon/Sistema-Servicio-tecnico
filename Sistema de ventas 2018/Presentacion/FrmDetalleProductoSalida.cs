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
    public partial class FrmDetalleProductoSalida : Form
    {
        public FrmDetalleProductoSalida()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
       public int idSalida;
        private void FrmDetalleProductoSalida_Load(object sender, EventArgs e)
        {
            txtSalidaId.Text = idSalida.ToString();
            mostrarOcultar(false);
            DataSet ds = FDetalleProductoSalida.GetAll(Convert.ToInt32(txtSalidaId.Text));
            dt = ds.Tables[0];
            dgvDatos.DataSource = dt;
            dgvDatos.Columns["Id"].Visible = false;

            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    if (txtDetalleProductoSalidaId.Text == "")
                    {
                        DetalleProductoSalida detalleproductosalida = new DetalleProductoSalida();
                        detalleproductosalida.Producto.Id = Convert.ToInt32(txtProductoId.Text);
                        detalleproductosalida.Salida.Id = Convert.ToInt32(txtSalidaId.Text);
                        detalleproductosalida.Precio = Convert.ToDecimal(txtPrecio.Text);
                        detalleproductosalida.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                        int returnId = FDetalleProductoSalida.Insertar(detalleproductosalida);
                        if (returnId > 0)
                        {
                            foreach (DataGridViewRow row in dgvDatos.Rows)
                            {
                                Inventario inventario = new Inventario();
                                inventario.Producto.Id = Convert.ToInt32(row.Cells[0].Value);
                                inventario.Salida = Convert.ToDecimal(row.Cells[2].Value);
                                inventario.Stock = Convert.ToDecimal(row.Cells[2].Value) - Convert.ToDecimal(row.Cells["StockInicial"].Value);
                                inventario.DetalleVentaId = returnId;
                                FInventario.Insertar(inventario);
                            }
                            
                            FrmDetalleProductoSalida_Load(null, null);
                            habilitarBotones(false);
                        }



                    }
                    else
                    {
                        DetalleProductoSalida detalleproductosalida = new DetalleProductoSalida();
                        detalleproductosalida.Id = Convert.ToInt32(txtDetalleProductoSalidaId.Text);
                        detalleproductosalida.Producto.Id = Convert.ToInt32(txtProductoId.Text);
                        detalleproductosalida.Salida.Id = Convert.ToInt32(txtSalidaId.Text);
                        detalleproductosalida.Precio = Convert.ToDecimal(txtPrecio.Text);
                        detalleproductosalida.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                        int returnId = FDetalleProductoSalida.Actualizar(detalleproductosalida);
                        if (returnId > 0)
                        {
                            FrmDetalleProductoSalida_Load(null, null);
                            habilitarBotones(false);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string validarDatos()
        {
            string resultado = "";
            if (txtPrecio.Text == "")
            {
                resultado = "El campo Precio está vacío ";
                txtPrecio.Focus();
            }
            if (txtProducto.Text == "")
            {
                resultado = "El campo Producto está vacío";
                txtProducto.Focus();
            }

            return resultado;
        }
        public void mostrarOcultar(bool b)
        {

            txtProducto.Enabled = b;
            txtPrecio.Enabled = b;
            btnCargarProducto.Enabled = b;
            txtCantidad.Enabled = b;
        }
        public void habilitarBotones(bool b)
        {
            btnCancelar.Enabled = b;
            btnGuardar.Enabled = b;
            btnNuevo.Enabled = !b;
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mostrarOcultar(true);
            habilitarBotones(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDetalleProductoSalidaId.Text = "";
            txtSalidaId.Text = "";
            txtProductoId.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "1";
            mostrarOcultar(true);
            habilitarBotones(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmDetalleProductoSalida_Load(null, null);
            habilitarBotones(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DetalleProductoSalida detalleprodcutosalida = new DetalleProductoSalida();
                    detalleprodcutosalida.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FDetalleProductoSalida.Eliminar(detalleprodcutosalida);
                    if (returnId > 0)
                    {
                        FrmDetalleProductoSalida_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, talvez no hay aquipos registrados", "No se puede eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            asignatDatos();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             asignatDatos();
        }
        public void asignatDatos()
        {
            if (dgvDatos.CurrentRow != null)
            {
                txtDetalleProductoSalidaId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtProducto.Text = dgvDatos.CurrentRow.Cells["NombreProducto"].Value.ToString();
                txtPrecio.Text = dgvDatos.CurrentRow.Cells["Precio"].Value.ToString();
                txtCantidad.Text = dgvDatos.CurrentRow.Cells["Cantidad"].Value.ToString();
            }
        }

        private void btnCargarSalida_Click(object sender, EventArgs e)
        {
            FrmSalida_Vista form = new FrmSalida_Vista();
            form.Show();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            FrmProducto_Vista form = new FrmProducto_Vista();
            form.ShowDialog();
            txtPrecio.Text = form.precio;
            txtProducto.Text = form.descripcion;
            txtProductoId.Text = form.productoId;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtDetalleProductoSalidaId.Text = "";
            txtProductoId.Text = "";
            txtPrecio.Text = "";   
            txtProducto.Text = "";
            txtCantidad.Text = "1";
            habilitarBotones(true);
            mostrarOcultar(true);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones(false);
            FrmDetalleProductoSalida_Load(null, null);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones(true);
            mostrarOcultar(true);
        }
    }
}
