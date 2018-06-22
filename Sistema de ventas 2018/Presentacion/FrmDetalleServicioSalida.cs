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
    public partial class FrmDetalleServicioSalida : Form
    {
        public FrmDetalleServicioSalida()
        {
            InitializeComponent();
        }
       public int idSalida;//declaramos variable 
        DataTable dt1 = new DataTable();//variable para crear tabla
        private void FrmDetalleServicioSalida_Load(object sender, EventArgs e)
        {
            txtSalidaId.Text = idSalida.ToString();//validamos los campos del formulario
            mostrarOcultar(false);//deshabilitamos el metodo
            DataSet ds = FDetalleServicioSalida.GetAll(Convert.ToInt32(txtSalidaId.Text));//creamos un datased, un contenedor de datos hacemos una consulta a la clace FDetalleServicioSalida y su metodo GetAll, en ella el SalidaId
            dt1 = ds.Tables[0];//asignamos los datos del datased a la tabla
            dgvDatos.DataSource = dt1;//pasamos los datos de la tabla al datagridview
            dgvDatos.Columns["Id"].Visible = false;
           
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultad = validarDatos();
                if (sResultad == "")
                {
                    if (txtDetalleServicioId.Text == "")
                    {
                        DetalleServicioSalida detalleserviciosalida = new DetalleServicioSalida();//instanciamos nustra clace DetalleServicioSalida para rellear sus atributos
                        detalleserviciosalida.Salida.Id = Convert.ToInt32(txtSalidaId.Text);//validamos el campo del formulario
                        detalleserviciosalida.Servicio.Id = Convert.ToInt32(txtServicioId.Text);//validamos el campo de formulario
                        detalleserviciosalida.Precio = Convert.ToDecimal(txtPrecio.Text);
                        detalleserviciosalida.Cantidad= Convert.ToDecimal(txtCantidad.Text);
                        int returnId = FDetalleServicioSalida.Insertar(detalleserviciosalida);//ejecutamos el procedimiento almacenado para insertar
                        if (returnId > 0)
                        {
                            FrmDetalleServicioSalida_Load(null, null);//el formulario es nulo
                            habilitarBotones(false);//deshabiltamos el metodo
                        }
                    }
                    else
                    {
                        DetalleServicioSalida detalleserviciosalida = new DetalleServicioSalida();//instaciamos nuestra clace DetalleServicioSalida pata rellenar su atributos
                        detalleserviciosalida.Id = Convert.ToInt32(txtDetalleServicioId.Text);//validamos el campo del formulario
                        detalleserviciosalida.Salida.Id = Convert.ToInt32(txtSalidaId.Text);//validamos el campo el fomulario
                        detalleserviciosalida.Servicio.Id = Convert.ToInt32(txtServicioId.Text);
                        detalleserviciosalida.Precio = Convert.ToDecimal(txtPrecio.Text);
                        detalleserviciosalida.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                        int returnId = FDetalleServicioSalida.Actualizar(detalleserviciosalida);//ejecutamos el procedimeinto almacenado para Actualizar
                        if (returnId > 0)
                        {
                            FrmDetalleServicioSalida_Load(null, null);//el formulario es nulo
                            habilitarBotones(false);//deshabiltamos el metodo
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultad);//muestra error falta ingresar el campo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string validarDatos()//validamos todos los campos del formulario para que no se registren vacios 
        {
            string resultado = "";
            if (txtPrecio.Text == "")
            {
                resultado = "El campo Precio está vacío";
                txtPrecio.Focus();
            }
            if (txtServicio.Text == "")
            {
                resultado = "El campo Salida está vacío";
                txtServicio.Focus();
            }
            return resultado;
        }
        public void mostrarOcultar(bool b)//metodo para habilitar los campos en el formulario
        {
            txtPrecio.Enabled = b;
            txtServicio.Enabled = b;
            txtCantidad.Enabled = b;
            btnCargarServicio.Enabled = b;
        }
        public void habilitarBotones(bool b)//metodo para habilitar los botones en el formulario
        {
            btnCancelar.Enabled = b;
            btnGuardar.Enabled = b;
            btnNuevo.Enabled = !b;
        }

        private void btnNuevo_Click(object sender, EventArgs e)//vaciamos los campos del formulario para registrar un nuevo registro 
        {
            txtDetalleServicioId.Text = "";
            txtPrecio.Text = "";
            txtServicioId.Text = "";
            txtServicio.Text = "";
            txtCantidad.Text = "1";
            habilitarBotones(true);//habilitamos el metodo
            mostrarOcultar(true);//habilitamos el metodo
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);//habilitamos el metodo
            mostrarOcultar(true);//habilitamos el metodo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);//deshabilitamos el metodo
            FrmDetalleServicioSalida_Load(null, null);//el formulario es nulo
        }

       
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            asignarDatos();//llamamos al metodo
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            asignarDatos();//llamamos al metodo
        }
        public void asignarDatos()
        {
            if (dgvDatos.CurrentRow != null)//si el datagridview es nulo
            {
                txtDetalleServicioId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();//validar los campos del formulario con el datagridview 
                txtServicio.Text = dgvDatos.CurrentRow.Cells["DescripcionServicio"].Value.ToString();//validar los campos del formulario con el datagridview
                txtPrecio.Text = dgvDatos.CurrentRow.Cells["Precio"].Value.ToString();
                txtCantidad.Text= dgvDatos.CurrentRow.Cells["Cantidad"].Value.ToString();
            }
        }

        private void btnCargarServicio_Click(object sender, EventArgs e)
        {
            FrmServicio_Vista form = new FrmServicio_Vista();//abrimos nuevo formulario
            form.ShowDialog();//mostramo el formulario

            txtPrecio.Text = form.precio;//el campo txtPrecio es igual al form a su variable, precio
            txtServicio.Text = form.descripcion;//el campo txtServicio es igual al form a su variable, descripcion
            txtServicioId.Text = form.servicioId;
            txtCantidad.Focus();//campo habilitado
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones(true);//habilitamos el metodo
            mostrarOcultar(true);//habilitamos el metodo
        }
    }
}
