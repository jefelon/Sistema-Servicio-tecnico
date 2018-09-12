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
    public partial class FrmSalida : Form
    {
        public FrmSalida()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    if (txtId.Text == "")
                    {
                        Salida salida = new Salida();//instanciamo nuestra clase Salida para rellenarle sus atributos
                        salida.Numero = Convert.ToInt32(txtNumeroSalida.Text);////validamos el campo del formulario
                        salida.FechaSalida = dtpFecha.Value;
                        salida.Diagnostico = txtDiagnostico.Text;
                        salida.Estado = txtEstadoSalida.Text;
                        int returnId = FSalida.Insertar(salida);//ejecutamos el procedimiento para Insertar
                        if (returnId > 0)
                        {
                            FrmSalida_Load(null, null);//recarga el formulario
                            habilitarBotones(false);//el metodo esta deshabilitado
                        }
                    }
                    else
                    {
                        Salida salida = new Salida();//instanciamo nuestra clase Salida para rellenarle sus atributos
                        salida.Id = Convert.ToInt32(txtId.Text);
                        salida.Numero = Convert.ToInt32(txtNumeroSalida.Text);////validamos el campo del formulario
                        salida.FechaSalida = dtpFecha.Value;
                        salida.Diagnostico = txtDiagnostico.Text;
                        salida.Estado = txtEstadoSalida.Text;

                        int returnId = FSalida.Actualizar(salida);
                        if (returnId > 0)
                        {
                            MessageBox.Show("Entrega finalizada","La salida o entrega con número" + txtNumeroSalida.Text);
                            FrmSalida_Load(null, null);
                            habilitarBotones(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);

                }           
        }
        public string validarDatos()//validamos los campos del formulario para no registrar vacios
        {
            string resultado = "";
            if (txtNumeroSalida.Text == "")
            {
                resultado = "El campo Numero está vacío";
                txtNumeroSalida.Focus();
            }
            return resultado;
        }

        private void FrmSalida_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);//deshabilitar el metodo
            habilitarBotones(false);//deshabilitar el metodo

            if(txtBuscarIngreso.Text!="")
            {
                cargarIngreso(Convert.ToInt32(txtBuscarIngreso.Text));
            }
        }
        public void mostrarOcultar(bool b)//metodo para habilitar los campos del formulario
        {
            txtDiagnostico.Enabled = b;
            txtEstadoSalida.Enabled = b;
            txtNumeroSalida.Enabled = b;
            dtpFecha.Enabled = b;

        }
        public void habilitarBotones(bool b)//metodo para habilitar los botones del formulario
        {
            btnCancelar.Enabled = b;
            btnGuardar.Enabled = b;
            btnEntregarEquipo.Enabled = b;
            btnEditar.Enabled = b;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);//habilitamos el metodo de mostrarOcultar
            FrmSalida_Load(null, null);//el formulario es nulo
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mostrarOcultar(true);//habilitamos el metodo de mostrarOcultar
            habilitarBotones(true);//habilitamos el metodo de habilitaBotones
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmGenerarSalida frm = new FrmGenerarSalida();//abrimos nuevo formulario
            frm.ingresoId = Convert.ToInt32(txtIdIngreso.Text);
            frm.ShowDialog();//mostramos el formulario
            mostrarOcultar(true);//habilitamos el metodo de mostrarOcultar

            txtId.Text = frm.idSalida.ToString();//el valor de txtId se mostrara en el otro formulario
            txtNumeroSalida.Text = frm.idSalida.ToString();

            btnAgregarProductos.Enabled = true;//habilitamos el boton para agregar
            btnAgregarServicios.Enabled = true;//habilitamos el boton para agregar
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FrmDetalleProductoSalida form = new FrmDetalleProductoSalida();//abrimos nuevo formulario
            form.idSalida = Convert.ToInt32(txtId.Text);//validamos el idSalida en el formulario
            form.ShowDialog();//mostramos el formulario

            cargarDetalleProductos();//llamamos al metodo
        }

        private void cargarDetalleProductos()
        {
            DataTable dt = new DataTable();//varaiables para crear la tabla
            DataSet ds = FDetalleProductoSalida.GetAll(Convert.ToInt32(txtId.Text));//creamos un dataset, un contenedor de datos y hacemos una consulta con la clase y su método GetAll, en ella el Id
            dt = ds.Tables[0];//asignamos los datos del datased a la tabla
            dgvDetalleProductoSalida.DataSource = dt; //pasamos los datos de la tabla al datagridview
            dgvDetalleProductoSalida.Columns["ProductoId"].Visible = false;
            //dgvDetalleProductoSalida.Columns["Id"].Visible = false;

            double total = 0;

            foreach (DataGridViewRow row in dgvDetalleProductoSalida.Rows)
            {
                total += Convert.ToDouble(row.Cells["Importe"].Value);
            }

            txtTotalProducto.Text = String.Format("{0:n2}", total);
        }

        private void btnAgregarServicios_Click(object sender, EventArgs e)
        {
            FrmDetalleServicioSalida form = new FrmDetalleServicioSalida();//abrimos nuevo formulario 
            form.idSalida = Convert.ToInt32(txtId.Text);//validamos el campo del formulario
            form.ShowDialog();//mostramos el formulario

            cargarDetalleServicios();//llmamos al metodo
        }

        private void cargarDetalleServicios()
        {

            DataTable dt = new DataTable();//variables para crear la tabla
            DataSet ds = FDetalleServicioSalida.GetAll(Convert.ToInt32(txtId.Text));//creamos un dataset, un contenedor de datos y hacemos una consulta con la clase y su método GetAll, en ella el Id         
            dt = ds.Tables[0];//asignamos los datos de datased a la tabla
            dgvDetalleServicioSalida.DataSource = dt;//pasamos los datos de la tabla al datagridview

            double total = 0;

            foreach (DataGridViewRow row in dgvDetalleServicioSalida.Rows)
            {
                total += Convert.ToDouble(row.Cells["Importe"].Value);
            }

            txtTotalServicio.Text = String.Format("{0:n2}", total);
        }

        private void cargarIngreso(int numeroIngreso)
        {
            DataSet ds = FIngreso.Get(numeroIngreso);//creamos un datased un contenedor de datos y hacemos una consulta con la clase y su método Get
            DataTable dt = ds.Tables[0];//asignamos los datos de datased a la tabla 
            if (dt.Rows.Count <= 0)//si la tabla es menor o igual que cero
            {
                MessageBox.Show("No existe, revice el número e ingrese nuévamente.", "NO EXISTE REGISTRO");

                limpiarCampos();
            }

           else if(dt.Rows.Count > 0)
            {
                txtIdIngreso.Text = dt.Rows[0]["Id"].ToString();
                if (dt.Rows[0]["Razon_social"].ToString() != "")//si la tabla con el campo "Razon_social" tiene contenido
                {
                    txtNombreRS.Text = dt.Rows[0]["Razon_social"].ToString();//asignamos la razon social
                }
                else//de lo contrario
                {
                    txtNombreRS.Text = dt.Rows[0]["Nombre"].ToString();// asignamos el valor de nombre
                }
                txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();//validamos el campo con el valor de datagridview 
                dtpFechaIngreso.Text = dt.Rows[0]["FechaIngreso"].ToString();//validamos el campo con el valos de datagridview
                txtMotivoIngreso.Text = dt.Rows[0]["MotivoIngreso"].ToString();
                txtObservacionExterna.Text = dt.Rows[0]["ObservacionExterna"].ToString();
                txtObservacionInterna.Text = dt.Rows[0]["ObservacionInterna"].ToString();
                txtAdelanto.Text = dt.Rows[0]["Adelanto"].ToString();
                txtEstadoIngreso.Text = dt.Rows[0]["Estado"].ToString();

                txtEquipo.Text = dt.Rows[0]["Descripcion"].ToString();
                txtMarca.Text = dt.Rows[0]["Marca"].ToString();
                textBox4.Text = dt.Rows[0]["Modelo"].ToString();

                cargarSalida();

                habilitarBotones(true);//habilitamos el metodo
                
            }
        }

        private void limpiarCampos()
        {
            dgvDetalleProductoSalida.DataSource = null;
            dgvDetalleServicioSalida.DataSource = null;

            txtNombreRS.Text= "";
            txtDireccion.Text = "";
            dtpFechaIngreso.Text = "";
            txtMotivoIngreso.Text = "";
            txtObservacionExterna.Text = "";
            txtObservacionInterna.Text = "";
            txtAdelanto.Text = "";
            txtEstadoIngreso.Text = "";
            txtEquipo.Text = "";
            txtMarca.Text = "";
            textBox4.Text = "";
            txtNumeroSalida.Text= "";

            txtTotalProducto.Text= "";
            txtTotalServicio.Text= "";

            txtId.Text= "";
            txtIdIngreso.Text= "";
        }

        private void txtBuscarIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//si precionamos Enter
            {
                e.SuppressKeyPress = true;//tecla precionado
                cargarIngreso(Convert.ToInt32(txtBuscarIngreso.Text));//llamamos al metodo y muestra los datos de la clace FIngreso 
               //cargarDetalle(Convert.ToInt32(txtBuscarIngreso.Text));
            }
            
        }

        private void cargarSalida()
        {
            DataSet ds5 = FSalida.Get(Convert.ToInt32(txtIdIngreso.Text));
            DataTable dt5 = ds5.Tables[0];

            if(dt5.Rows.Count>0)
            {
                txtId.Text = dt5.Rows[0]["Id"].ToString();
                txtNumeroSalida.Text = dt5.Rows[0]["Numero"].ToString();
                txtDiagnostico.Text = dt5.Rows[0]["Diagnostico"].ToString();
                dtpFecha.Text = dt5.Rows[0]["FechaSalida"].ToString();
                txtEstadoSalida.Text = dt5.Rows[0]["Estado"].ToString();

                cargarDetalleProductos();
                cargarDetalleServicios();

                btnEntregarEquipo.Enabled = false;
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Report frmComprobantes = new Report();
                frmComprobantes.Load(@"Reportes/ReporteSalida.frx");
                frmComprobantes.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
                frmComprobantes.SetParameterValue("Numero", Convert.ToInt32(txtBuscarIngreso.Text));
                frmComprobantes.SetParameterValue("IngresoId", Convert.ToInt32(txtIdIngreso.Text));
                frmComprobantes.SetParameterValue("SalidaId", Convert.ToInt32(txtId.Text));
                frmComprobantes.Show();
            }
        }

        private void dgvDetalleServicioSalida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;

                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                   DetalleServicioSalida detalleServicioSalida = new DetalleServicioSalida();
                    detalleServicioSalida.Id = Convert.ToInt32(dgvDetalleServicioSalida.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FDetalleServicioSalida.Eliminar(detalleServicioSalida);
                    if (returnId > 0)
                    {
                        cargarDetalleServicios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar, llamar a soporte...", "No se puede eliminar");
                    }
                }

            }
        }

        private void dgvDetalleProductoSalida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;

                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DetalleProductoSalida detalleProductoSalida = new DetalleProductoSalida();
                    detalleProductoSalida.Id = Convert.ToInt32(dgvDetalleProductoSalida.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FDetalleProductoSalida.Eliminar(detalleProductoSalida);
                    if (returnId > 0)
                    {
                        cargarDetalleProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar, llamar a soporte...", "No se puede eliminar");
                    }
                }

            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            mostrarOcultar(true);
            btnAgregarProductos.Enabled = true;
            btnAgregarServicios.Enabled = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
