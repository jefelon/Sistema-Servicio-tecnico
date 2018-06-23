using FastReport;
using Sistema_de_ventas_2018.Datos;
using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_2018.Presentacion
{
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
            mostrarOcultar(false);


        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            habilitarBotones(false);
            cargar_TipoDocumento();
            if (txtId.Text != "")
            {
                cargarCompras(Convert.ToInt32(txtId.Text));
                dgvProveedor.Visible = false;
            }
            //hola
        }

        private void cargarCompras(int id)
        {
            DataTable dtp1 = new DataTable();
            DataSet ds = FCompra.Get(id);
            dtp1 = ds.Tables[0];
            txtProveedor.Text = dtp1.Rows[0]["NombreProveedor"].ToString();
            txtProveedorId.Text = dtp1.Rows[0]["ProveedorId"].ToString();
            txtNro_comprobante.Text = dtp1.Rows[0]["Nro_comprobante"].ToString();
            dtpFecha.Text = dtp1.Rows[0]["Fecha"].ToString();
            cmbTipoDocumento.Text = dtp1.Rows[0]["TipoDoc"].ToString();


            DataTable dtd2 = new DataTable();
            DataSet ds2 = FDetalleCompra.GetAll(id);
            dtd2 = ds2.Tables[0];
            dgvDetalle.Columns[0].Visible = false;
            dgvDetalle.Columns[1].Visible = false;
            dgvDetalle.Columns[2].Visible = false;
            dgvDetalle.Columns[3].Visible = false;
            dgvDetalle.Columns[4].Visible = false;
            dgvDetalle.DataSource = dtd2;
            dgvDetalle.Columns["Id"].Visible = false;
            dgvDetalle.Columns["CompraId"].Visible = false;
            dgvDetalle.Columns["ProductoId"].Visible = false;
            dgvDetalle.Columns["TipoDocumento"].Visible = false;
            //            Id
            //CompraId
            //ProductoId
            //TipoDocumento

        }

        DataTable dt1 = new DataTable();
        public void cargar_TipoDocumento()
        {
            DataSet ds = FTipoDocumento.GetAll();
            dt1 = ds.Tables[0];
            cmbTipoDocumento.ValueMember = "Id";
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.DataSource = dt1;
        }
        public void listarProveedor()
        {
            try

            {
                DataSet ds = FCompra.Buscar(txtProveedor.Text);
                DataTable dt = ds.Tables[0];


                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay resultados para su criterio de busqueda, intente nuévamente", "No hay resultados");
                    dgvProveedor.DataSource = null;
                    dgvProveedor.Visible = false;
                }
                if (txtProveedor.TextLength < 1)
                {
                    dgvProveedor.Visible = false;
                }
                else
                {
                    dgvProveedor.DataSource = dt;
                    dgvProveedor.Columns["Id"].Visible = false;
                    dgvProveedor.Columns["Ruc"].Visible = false;
                    dgvProveedor.Columns["Direccion"].Visible = false;
                    dgvProveedor.Columns["Telefono"].Visible = false;
                    dgvProveedor.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {//Id, ProveedorId, UsuarioId, TipoDocumentoId, Nro_comprobante, Fecha
                    Compra compra = new Compra();
                    compra.Proveedor.Id = Convert.ToInt32(txtProveedorId.Text);
                    compra.Usuario = Usuario.Id;
                    compra.TipoDocumento.Id = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                    compra.Nro_compronbante = txtNro_comprobante.Text;
                    compra.Fecha = dtpFecha.Value;
                    int returnId = FCompra.Insertar(compra);
                    if(returnId > 0)
                    {
                        foreach(DataGridViewRow row in dgvDetalle.Rows)
                        {//Id, CompraId, ProductoId, Cantidad, PrecioUnitario, ConversionId
                            DetalleCompra detallecompra = new DetalleCompra();
                            detallecompra.Compra.Id = returnId;
                            detallecompra.Producto.Id = Convert.ToInt32(row.Cells[0].Value);
                            detallecompra.Cantidad = Convert.ToDecimal(row.Cells[2].Value);
                            detallecompra.PrecioUnitario = Convert.ToDecimal(row.Cells[3].Value);
                            int returnDetalleId=FDetalleCompra.Insertar(detallecompra);

                            if (returnDetalleId > 0)
                            {
                                Inventario inventario = new Inventario();
                                inventario.Producto.Id = Convert.ToInt32(row.Cells[0].Value);
                                inventario.Entrada = Convert.ToDecimal(row.Cells[2].Value);                                
                                inventario.DetalleCompraId = returnDetalleId;

                                FInventario.InsertarCompra(inventario);
                            }     
                        }
                    }
                    MessageBox.Show("La compra numero " + txtNro_comprobante.Text + " se insertó correctamente");
                    FrmCompra_Load(null, null);
                    btnNuevo.PerformClick();
                    mostrarOcultar(false);
                    
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                    FrmCompra_Load (null, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string validarDatos()
        {//Id, ProveedorId, UsuarioId, TipoDocumentoId, Nro_comprobante, Fecha
            string resultado = "";
            if (txtProveedor.Text == "")
            {
                resultado = "El campo Proveedor está vacío";
                txtProveedor.Focus();
            }
            if (cmbTipoDocumento.Text == "")
            {
                resultado = "Falta seleccionar Documento";
                cmbTipoDocumento.Focus();
            }
            if (txtCantidad.Text == "")
            {
                resultado = "El campo Cantidad está vacío";
                txtCantidad.Focus();
            }
            return resultado;
        }
        public void mostrarOcultar(bool b)
        {
            txtCantidad.Enabled = b;
            txtNro_comprobante.Enabled = b;
            txtPrecio.Enabled = b;
            txtProducto.Enabled = b;
            txtProveedor.Enabled = b;
            dtpFecha.Enabled = b;
            btnCargarProducto.Enabled = b;
            dtpFecha.Enabled = b;
            cmbTipoDocumento.Enabled = b;
        }
        public void habilitarBotones(bool b)
        {
            btnAgregar.Enabled = b;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
            txtCantidad.Text = "";
            txtNro_comprobante.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtProveedor.Text = "";
            dtpFecha.Text = "";
            dtpFecha.Text = "";
            txtProductoId.Text = "";
            txtProveedorId.Text = "";
            txtId.Text = "";
            cmbTipoDocumento.Text = "";
            habilitarBotones(false);
            mostrarOcultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            FrmCompra_Load(null, null);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Add(txtProductoId.Text, txtProducto.Text, txtCantidad.Text, txtPrecio.Text, Convert.ToDecimal(txtPrecio.Text) * Convert.ToDecimal(txtCantidad.Text));
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);
            FrmProducto_Vista form = new FrmProducto_Vista();
            form.ShowDialog();
            txtProductoId.Text = form.productoId;
            txtProducto.Text = form.descripcion;
            txtPrecio.Text = form.precio;


        }
        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                dgvProveedor.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                dgvProveedor.Focus();
            }
        }
        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            listarProveedor();
        }
        private void dgvProveedor_DoubleClick(object sender, EventArgs e)
        {
            asignarProveedor();
        }
        private void asignarProveedor()
        {
            if (dgvProveedor.CurrentRow != null)
            {

                if (dgvProveedor.CurrentRow.Cells["Nombre"].Value.ToString().Length > 0)
                {
                    txtProveedorId.Text = dgvProveedor.CurrentRow.Cells["Id"].Value.ToString();
                    txtProveedor.Text = dgvProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                    dgvProveedor.DataSource = null;
                    dgvProveedor.Visible = false;
                }
                else
                {
                    txtProveedorId.Text = dgvProveedor.CurrentRow.Cells["Id"].Value.ToString();
                    txtProveedor.Text = dgvProveedor.CurrentRow.Cells["Ruc"].Value.ToString();
                    dgvProveedor.DataSource = null;
                    dgvProveedor.Visible = false;
                }
            }
        }

        private void dgvProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                asignarProveedor();
            }
        }
        
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            double igv = 0;
            double subtotal = 0;
            double total = 0;

            foreach(DataGridViewRow row in dgvDetalle.Rows)
            {
                total += Convert.ToDouble(row.Cells["Importe"].Value);
                
            }
            subtotal = total / 1.18;
            igv = (total / 1.18) * 0.18;
            Report frmComprobanteCompra = new Report();
            frmComprobanteCompra.Load(@"Reportes/ComprobanteCompra.frx");
            frmComprobanteCompra.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
            frmComprobanteCompra.SetParameterValue("Id", Convert.ToInt32(txtId.Text));
            frmComprobanteCompra.SetParameterValue("Igv", igv);
            frmComprobanteCompra.SetParameterValue("SubTotal", subtotal);
            frmComprobanteCompra.Show();
        }
    }
}
