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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        DataTable dt1 = new DataTable();
        public void cargar_Marca()
        {
            DataSet ds = FMarca.GetAll();
            dt1 = ds.Tables[0];
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Nombre";
            cmbMarca.DataSource = dt1;
        }
        DataTable dt2 = new DataTable();
        public void cargar_Modelo()
        {//modelo unidad categoria proveedor
            DataSet ds = FModelo.GetAll();
            dt2 = ds.Tables[0];
            cmbModelo.ValueMember = "Id";
            cmbModelo.DisplayMember = "Nombre";
            cmbModelo.DataSource = dt2;
        }
        DataTable dt3 = new DataTable();
        public void cargar_UnidadMedida()
        {
            DataSet ds = FUnidadMedida.GetAll();
            dt3 = ds.Tables[0];
            cmbUnidadMedia.ValueMember = "Id";
            cmbUnidadMedia.DisplayMember = "Nombre";
            cmbUnidadMedia.DataSource = dt3;
        }
        DataTable dt4 = new DataTable();
        public void cargar_Categoria()
        {
            DataSet ds = FCategoria.GetAll();
            dt4 = ds.Tables[0];
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.DataSource = dt4;
        }
        DataTable dt5 = new DataTable();
        public void cargar_Proveedor()
        {
            DataSet ds = FProveedor.GetAll();
            dt5 = ds.Tables[0];
            cmbProveedor.ValueMember = "Id";
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.DataSource = dt5;
        }
            

        private void btnGuardar_Click(object sender, EventArgs e)
        { //Id, Codigo, Nombre, PrecioCompra, PrecioVenta, StockMinimo, StockMaximo, MarcaId, ModeloId, UnidadMedidaId, CategoriaId, ProveedorId, Ubicacion, FechaRegistro
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    //Id, Codigo, Nombre, PrecioCompra, PrecioVenta, StockMinimo, StockMaximo, MarcaId, ModeloId, UnidadMedidaId, CategoriaId, ProveedorId, Ubicacion, FechaRegistro
                    if (txtId.Text == "")
                        {
                            Producto producto = new Producto();
                            producto.Codigo = txtCodigo.Text;
                            producto.Nombre = txtNombre.Text;
                            producto.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                            producto.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                            producto.StockMinimo = Convert.ToDouble(txtStockMinimo.Text);
                            producto.StockMaximo = Convert.ToDouble(txtStockMáximo.Text);
                            producto.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
                            producto.Modelo.Id = Convert.ToInt32(cmbModelo.SelectedValue);
                            producto.UnidadMedida.Id = Convert.ToInt32(cmbUnidadMedia.SelectedValue);
                            producto.Categoria.Id = Convert.ToInt32(cmbCategoria.SelectedValue);
                            producto.Proveedor.Id = Convert.ToInt32(cmbProveedor.SelectedValue);
                            producto.Ubicacion = txtUbicacion.Text;
                            producto.FechaRegistro = dtpFechaRegistro.Value;
                            int returnId = FProducto.Insertar(producto);
                            if (returnId > 0)
                            {
                                FrmProducto_Load(null, null);
                                habilitarBotones(false);
                            }
                        }
                else
                {
                            Producto producto = new Producto();
                            producto.Id = Convert.ToInt32(txtId.Text);
                            producto.Codigo = txtCodigo.Text;
                            producto.Nombre = txtNombre.Text;
                            producto.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                            producto.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                            producto.StockMinimo = Convert.ToDouble(txtStockMinimo.Text);
                            producto.StockMaximo = Convert.ToDouble(txtStockMáximo.Text);
                            producto.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
                            producto.Modelo.Id = Convert.ToInt32(cmbModelo.SelectedValue);
                            producto.UnidadMedida.Id = Convert.ToInt32(cmbUnidadMedia.SelectedValue);
                            producto.Categoria.Id = Convert.ToInt32(cmbCategoria.SelectedValue);
                            producto.Proveedor.Id = Convert.ToInt32(cmbProveedor.SelectedValue);
                            producto.Ubicacion = txtUbicacion.Text;
                            producto.FechaRegistro = dtpFechaRegistro.Value;
                            int returId = FProducto.Actualizar(producto);
                            if (returId > 0)
                            {
                                FrmProducto_Load(null, null);
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
            if (txtCodigo.Text == "")
            {
                resultado = "El campo codigo está vacío";
                txtCodigo.Focus();
            }
            if (txtNombre.Text == "")
            {
                resultado = "El campo nombre está vacío";
                txtNombre.Focus();
             }
            if (txtPrecioCompra.Text=="")
            {
                resultado = "El campo Precio compra está vacío";
                txtPrecioCompra.Focus();
            }
            if (txtPrecioVenta.Text == "")
            {
                resultado = "El campo precioventa está vacío";
                txtPrecioVenta.Focus();
            }
            if (txtStockMinimo.Text == "")
            {
                resultado = "el campo stock minimo está vacío";

            }
            if (cmbMarca.Text == "")
            {
                resultado = "Falta seleccionar Marca";
                cmbMarca.Focus();
            }
            if (cmbModelo.Text == "")
            {
                resultado = "Falta seleccionar Modelo";
                cmbModelo.Focus();
            }
            if (cmbUnidadMedia.Text == "")
            {
                resultado = "Falta selecionar UnidadMedida";
                cmbUnidadMedia.Focus();
            }
            if (cmbCategoria.Text == "")
            {
                resultado = "Falta seleccionar Categoría";
                cmbCategoria.Focus();
            }
            if (cmbProveedor.Text == "")
            {
                resultado = "Falta selecionar Proveedor";
                cmbProveedor.Focus();
            }
            if (txtUbicacion.Text == "")
            {
                resultado = "El campo ubicacion está vacío";
                txtUbicacion.Focus();
            }
            return resultado;
        }
        DataTable dt0 = new DataTable();
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            cargar_Marca();
            cargar_Categoria();
            cargar_Modelo();
            cargar_Modelo();
            cargar_Proveedor();
            cargar_UnidadMedida();
            try
            {
                DataSet ds = FProducto.GetAll();
                dt0 = ds.Tables[0];
                dgvDatos.DataSource = dt0;
                dgvDatos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void mostrarOcultar(bool b)
        {//Id, Codigo, Nombre, PrecioCompra, PrecioVenta, StockMinimo, StockMaximo, MarcaId, ModeloId, UnidadMedidaId, CategoriaId, ProveedorId, Ubicacion, FechaRegistro
            txtCodigo.Enabled = b;
            txtNombre.Enabled = b;
            txtPrecioCompra.Enabled = b;
            txtPrecioVenta.Enabled = b;
            txtStockMinimo.Enabled = b;
            txtStockMáximo.Enabled = b;
            cmbMarca.Enabled = b;
            cmbModelo.Enabled = b;
            cmbUnidadMedia.Enabled = b;
            cmbCategoria.Enabled = b;
            cmbProveedor.Enabled = b;
            txtUbicacion.Enabled = b;
            dtpFechaRegistro.Enabled = b;
        }
        public void habilitarBotones(bool b)
        {
            btnCancelar.Enabled = b;
            btnEditar.Enabled =! b;
            btnEliminar.Enabled =! b;
            btnGuardar.Enabled = b;
            btnNuevo.Enabled = !b;
        }
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            txtId.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtStockMinimo.Text = "";
            txtStockMáximo.Text = "";
            cmbMarca.Text = "";
            cmbModelo.Text = "";
            cmbUnidadMedia.Text = "";
            cmbCategoria.Text = "";
            cmbProveedor.Text = "";
            txtUbicacion.Text = "";
            dtpFechaRegistro.Text = "";
            habilitarBotones(true);
            mostrarOcultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            FrmProducto_Load(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mostrarOcultar(true);
            habilitarBotones(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(txtId.Text);
                    int returnId = FProducto.Eliminar(producto);
                    if (returnId > 0)
                    {
                        FrmProducto_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar, talvez no hay marca registrada", "No se puede eliminar");
                    }
                } 
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void asignarDatos()
        {
            if (dgvDatos.CurrentRow != null)
            {//Id, Codigo, Nombre, PrecioCompra, PrecioVenta, StockMinimo, StockMaximo, MarcaId, ModeloId, UnidadMedidaId, CategoriaId, ProveedorId, Ubicacion, FechaRegistro
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtCodigo.Text = dgvDatos.CurrentRow.Cells["Codigo"].Value.ToString();
                txtNombre.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPrecioCompra.Text = dgvDatos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = dgvDatos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                txtStockMinimo.Text = dgvDatos.CurrentRow.Cells["StockMinimo"].Value.ToString();
                txtStockMáximo.Text = dgvDatos.CurrentRow.Cells["StockMaximo"].Value.ToString();
                cmbMarca.Text = dgvDatos.CurrentRow.Cells["Marca"].Value.ToString();
                cmbModelo.Text = dgvDatos.CurrentRow.Cells["Modelo"].Value.ToString();
                cmbUnidadMedia.Text = dgvDatos.CurrentRow.Cells["UnidadMedida"].Value.ToString();
                cmbCategoria.Text = dgvDatos.CurrentRow.Cells["Categoria"].Value.ToString();
                cmbProveedor.Text = dgvDatos.CurrentRow.Cells["Proveedor"].Value.ToString();
                txtUbicacion.Text = dgvDatos.CurrentRow.Cells["Ubicacion"].Value.ToString();
                dtpFechaRegistro.Text = dgvDatos.CurrentRow.Cells["FechaRegistro"].Value.ToString();

            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            asignarDatos();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            asignarDatos();
        }
        private void Buscar(string nombre)
        {
            DataSet dsb1 = FProducto.GetBuscar(nombre);
            DataTable dtb1 = dsb1.Tables[0];
            dgvDatos.DataSource = dtb1;
        }

       
    }
}
