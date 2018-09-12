using FastReport;
using Sistema_de_ventas_2018.Datos;
using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_2018.Presentacion
{
    public partial class FrmVenta : Form
    {
        private static DataTable dt = new DataTable();
        public FrmVenta()
        {
            InitializeComponent();
        }
       
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            habilitarBotones(false);//el metodo de habilitarBotones esta deshabilitado  
            cargar_Comprobante();//mostramos en el formulario el metodo de cargar_Datos          
            mostrarOcultar(false);//el metodo de habilitarBotones esta deshabilitado  
            if(txtId.Text!="")
            {
               cargarComprobante(Convert.ToInt32(txtId.Text));
                dgvClientes.Visible = false;
            }

        }

        private void cargarComprobante(int id)
        {
                DataTable dt2 = new DataTable();
                DataSet ds4 = FVenta.Get(id);//mostramos todos los datos registrados 
                dt2 = ds4.Tables[0];//asignamos los datos del datased a la tabla
                txtClienteId.Text =dt2.Rows[0]["ClienteId"].ToString();
                txtCliente.Text= dt2.Rows[0]["NombreCliente"].ToString();
                cmbTipoDocumento.Text = dt2.Rows[0]["Tipo"].ToString();
                cmbSerie.Text = dt2.Rows[0]["Serie"].ToString();
                txtNumeroDocumento.Text = dt2.Rows[0]["NUmeroDocumento"].ToString();
                dtpFecha.Text = dt2.Rows[0]["Fecha"].ToString();


                DataTable dt3 = new DataTable();
                DataSet ds = FDetalleVenta.GetAll(id);//creamos un datased, un contenedor de datos hacemos una consulta a la clace FServicio y su metodo GetAll, en ella el SalidaId
                dt3 = ds.Tables[0];//asignamos los datos del datased a la tabla
                dgvDetalle.Columns[0].Visible = false;
                dgvDetalle.Columns[1].Visible = false;
                dgvDetalle.Columns[2].Visible = false;
                dgvDetalle.Columns[3].Visible = false;
                dgvDetalle.Columns[4].Visible = false;

                dgvDetalle.DataSource = dt3;

                dgvDetalle.Columns["Id"].Visible = false;
                dgvDetalle.Columns["VentaId"].Visible = false;
                dgvDetalle.Columns["ProductoId"].Visible = false;
                dgvDetalle.Columns["TipoDocumento"].Visible = false;                
           
        }

        DataTable dt2 = new DataTable();//varaiables para crear la tabla
        DataTable dt5 = new DataTable();
        public void cargar_Comprobante()//mostramos en el cmbTipoDocumento los Tipos de documentos registrados 
        {
                DataSet ds = FTipoDocumento.GetAll();//mostramos todos los datos registrados 
                dt2 = ds.Tables[0];//asignamos los datos del datased a la tabla
                cmbTipoDocumento.ValueMember = "Id";//visualizamos el id de tabla de TipoDocumento 
                cmbTipoDocumento.DisplayMember = "Nombre";//visualizamos el Nombre de tabla de TipoDocumento
                cmbTipoDocumento.DataSource = dt2;//los se mostraran en el cmbTipoDocumento
                cmbTipoDocumento.SelectedIndex = 1;//del cmbTipoDocumento su valor inicial es 1
            
        }
        
        public void listarClientes()
        {
                DataSet ds = FCliente.Buscar(txtCliente.Text);//instanciamos nuestra clase para buscar sus atributos
                 DataTable dt = ds.Tables[0];//asignamos los datos del datased a la tabla


                if (dt.Rows.Count <= 0)//si es menor o igual a cero muestra el mensaje
                {
                    MessageBox.Show("No hay resultados para su criterio de busqueda, intente nuévamente", "No hay resultados");
                    dgvClientes.DataSource = null;//el datagrid del cliente es nulo
                    dgvClientes.Visible = false;//no se muestra el datagrid del cliente
                }
                if (txtCliente.TextLength<1)//si el txtCliente no tiene texto
                {
                    dgvClientes.Visible = false;//no se muestra el datagrid del cliente
                }
                else
                {
                    dgvClientes.DataSource = dt;//dgvClientes es igual a los datos de la tabla
                    dgvClientes.Columns["Id"].Visible = false;
                    dgvClientes.Columns["Ruc"].Visible = false;
                    dgvClientes.Columns["Dni"].Visible = false;
                    dgvClientes.Columns["Numero_Doc"].Visible = false;
                    dgvClientes.Visible = true;//se muestran los clientes en el dgvCliente

                }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    Venta venta = new Venta();//instanciamo nuestra clase Venta para rellenarle sus atributos
                    venta.Cliente.Id = Convert.ToInt32(txtClienteId.Text);//validamos el campo del formulario
                    venta.UsuarioId = Usuario.Id;
                    venta.TipoDocumento.Id = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                    venta.Fecha = dtpFecha.Value;
                    venta.Serie = cmbSerie.Text;
                    venta.NumeroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
                    int returId = FVenta.Insertar(venta);//Ejecutamos el procedimiento almacenado para Insertar.
                    if (returId > 0)
                    {



                        foreach (DataGridViewRow row in dgvDetalle.Rows)//contabilizamos los datos de dgvDatos con foreach
                        {
                            DetalleVenta detalleventa = new DetalleVenta();//instanciamo nuestra clase DetalleVenta para rellenarle sus atributos
                            detalleventa.Venta.Id = returId;//validamos el campo del formulario
                            detalleventa.Producto.Id = Convert.ToInt32(row.Cells[0].Value);//validamos el campo del formulario
                            detalleventa.Cantidad = Convert.ToDecimal(row.Cells[2].Value);
                            detalleventa.PrecioUnitario = Convert.ToDecimal(row.Cells[3].Value);
                            detalleventa.PrecioVenta = Convert.ToDecimal(row.Cells[4].Value);

                            int returnDetalleId = FDetalleVenta.Insertar(detalleventa);//Ejecutamos el procedimiento almacenado para Insertar 

                            if (returnDetalleId > 0)

                            {
                                Inventario inventario = new Inventario();
                                inventario.Producto.Id = Convert.ToInt32(row.Cells[0].Value);
                                inventario.Salida = Convert.ToDecimal(row.Cells[2].Value);
                                inventario.DetalleVentaId = returnDetalleId;

                                FInventario.Insertar(inventario);
                            }                      
                            
                        }
                    }

                    MessageBox.Show("La venta numero " + txtNumeroDocumento.Text + " se insertó correctamente");//se muestra el mensaje con el numero de venta

                    btnNuevo.PerformClick();
                    mostrarOcultar(false);
                    FrmVenta_Load(null, null);// RECARGAR FORMULARIO

                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);//mensaje de error al no insertar un campo en el formulario
                    FrmVenta_Load(null, null);//el fomulario es nulo
                }            
        }
       
        public string validarDatos()//validamos todos los campos del formulario para que no se registren vacios 
        {
            string reultado = "";
            if (txtCliente.Text == "")
            {
                reultado = "El campo Cliente está vacío";
                txtCliente.Focus();
            }
            if (txtNumeroDocumento.Text == "")
            {
                reultado = "El campo N° Doc está vacío";
                txtNumeroDocumento.Focus();
            }
            if (cmbTipoDocumento.Text == "")
            {
                reultado = "El campo Tipo/Documneto está vacío";
                cmbTipoDocumento.Focus();
            }
            return reultado;
        }
       
        private void mostrarOcultar(bool b)//metodo para habilitar los campos del formulario
        {
            txtCliente.Enabled = b;
            cmbTipoDocumento.Enabled = b;
            dtpFecha.Enabled = b;
            txtCantidad.Enabled = b;
            txtPrecio.Enabled = b;
            txtPrecio.Enabled = b;
            txtProducto.Enabled = b;
            btnCargarProducto.Enabled = b;
        }
        private void habilitarBotones(bool b)//metodo para habilitar el boton
        {
            btnCancelar.Enabled = b;
            btnGuardar.Enabled = b;
            btnNuevo.Enabled = !b;
            btnAgregar.Enabled = b;
            btnImprimir.Enabled = b;
        }

        private void btnNuevo_Click(object sender, EventArgs e)//vaciamos los campos del formulario para insertar un nuevo registro
        {
            dgvDetalle.Rows.Clear();
            txtCliente.Text ="";
            txtCantidad.Text = "";
            txtClienteId.Text = "";
            txtPrecio.Text = "";
            txtProductoId.Text = "";
            txtProducto.Text = "";
            mostrarOcultar(true);//habilitamos el metodo de mostrarOcultar
            habilitarBotones(true);//deshabilitamos el metodo de habilitarBotones

            txtCliente.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmVenta_Load(null, null);//el fomulario es nulo
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double cantidad = 0;
            double stock = 0;

            DataSet ds1 = FStock.Get(Convert.ToInt32(txtProductoId.Text));
            DataTable dt1 = ds1.Tables[0];

            cantidad = Convert.ToDouble(txtCantidad.Text);
            stock= Convert.ToDouble(dt1.Rows[0]["Stock"]);

            if (stock<cantidad)
            {
                MessageBox.Show("No hay Stock suficiente, el stock actual es " + stock.ToString());
            }
            else {
                dgvDetalle.Rows.Add(txtProductoId.Text, txtProducto.Text, txtCantidad.Text, txtPrecio.Text, Convert.ToDecimal(txtPrecio.Text) * Convert.ToDecimal(txtCantidad.Text));//los datos del producto se agregan al dgvDatos
                calcularTotales();

            }
        }
        private void calcularTotales()
        {
            double subtotal = 0;
            double total = 0;
            double igv = 0;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                total += Convert.ToDouble(row.Cells["PrecioVenta"].Value);
            }

            subtotal = total / 1.18;
            igv = subtotal * 0.18;

            txtSubTotal.Text = String.Format("{0:n2}", subtotal);
            txtIgv.Text = String.Format("{0:n2}", igv);
            txtTotal.Text = String.Format("{0:n2}", total);
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            listarClientes();//llamamos el metodo de listarCliente en el txtCliente
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//si en el txtCliente es presionado el Enter
            {
                e.SuppressKeyPress = true;//si es precionado 
                dgvClientes.Focus();//se muestra dgvClientes en el formulario
            }

            if (e.KeyCode == Keys.Down)//si en el txtCliente es precionado el tecla Abajo 
            {
                e.SuppressKeyPress = true;//si es precionado
                dgvClientes.Focus();//se muestra el dgvCliente en el formulario
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            asignarCliente();//llamamos al metodo de asignarCliente
        }

        private void asignarCliente()
        {
            if (dgvClientes.CurrentRow != null)//si es nulo el dgvClientes
            {
                
                if (dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString().Length > 0)
                {
                    txtClienteId.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();//los datos Id y Nombre del dgvClientes tienen que mostrarse en los campos de formulario
                    txtCliente.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtRuc.Text = dgvClientes.CurrentRow.Cells["Dni"].Value.ToString();
                    dgvClientes.DataSource = null;//dgvClientes es nulo
                    dgvClientes.Visible = false;//dgvClientes no se muestra
                }
                else// de lo contrario
                {
                    txtClienteId.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();//los datos Id y Razon_social del dgvClientes tienen que mostrarse en los campos de formulario
                    txtCliente.Text = dgvClientes.CurrentRow.Cells["Razon_social"].Value.ToString();
                    txtRuc.Text= dgvClientes.CurrentRow.Cells["Ruc"].Value.ToString();
                    dgvClientes.DataSource = null;//dgvClientes es nulo
                    dgvClientes.Visible = false;//dgvClientes no se muestra
                }
            }

            btnCargarProducto.Focus();
        }

        private void dgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//si en el dgvClientes es precionado Enter
            {
                e.SuppressKeyPress = true;//si es precionado
                asignarCliente();//llamamos el metodo de asignarDatos
            }
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);//el metodo de habilitarBtones es verdadera(se muestra)
            FrmProducto_Vista form = new FrmProducto_Vista();//abrimos nuevo formulario
            form.ShowDialog();//mostramos el formulario
            txtProductoId.Text = form.productoId;//el campo txtProductoId es igual al form a su variable, productoId
            txtProducto.Text = form.descripcion;
            txtPrecio.Text = form.precio;

            txtCantidad.Focus();


        }

        private void cmbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(String.IsNullOrEmpty(cmbTipoDocumento.Text)) && !(String.IsNullOrEmpty(cmbSerie.Text)))//si son nulos los campos de cmbTipoDocumneto y dmbSerie
            {
                numeroDoc();//llamamos al metodo numeroDos
            }
            
        }

        private void numeroDoc()//genera el numero de serie
        {


            Venta venta = new Venta();//instanciamo nuestra clase Venta para rellenarle sus atributos
            venta.TipoDocumento.Id = Convert.ToInt32(cmbTipoDocumento.SelectedValue.ToString());//solo le pasaremos su atributo id
            venta.Serie =cmbSerie.Text;//validamos los datos.

            DataSet ds = FVenta.GenerarNumeroDocumento(venta);//Ejecutamos el procedimiento almacenado para Generar numero de documento.
            DataTable dt = ds.Tables[0];

            if (dt.Rows[0]["NumeroSiguiente"].ToString() == "")//si el NUmeroDocumento es vacío
            {
                txtNumeroDocumento.Text = "1";//txtNumeroDocumento es igual a 1
            }
            else
            {
                
                txtNumeroDocumento.Text = dt.Rows[0]["NumeroSiguiente"].ToString();
            }


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            double igv = 0;
            double subtotal = 0;
            double total = 0;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
 
                total += Convert.ToDouble(row.Cells["Importe"].Value);
            }

            subtotal = total / 1.18;
            igv = (total / 1.18) * 0.18;
            Report frmComprobantes = new Report();
            frmComprobantes.Load(@"Reportes/Comprobante.frx");
            frmComprobantes.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
            frmComprobantes.SetParameterValue("Id", Convert.ToInt32(txtId.Text));
            frmComprobantes.SetParameterValue("Igv", igv);
            frmComprobantes.SetParameterValue("SubTotal", subtotal);
            frmComprobantes.Show();
            //borrado
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress=true;
                btnAgregar.PerformClick();

            }
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroDoc();
        }
    }

}

