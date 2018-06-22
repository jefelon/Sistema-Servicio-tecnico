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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
               
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = valitarDatos();
                if (sResultado == "")
                {
                    if (txtId.Text == "")
                    {
                        if (txtTipodoc.Text!="" && txtRuc.Text !="" && txtDni.Text !="" && txtRazonsocial.Text!="" && txtNumerodoc.Text!="" && txtNombre.Text!="" && txtApellidoPaterno.Text !="" && txtApellidoMaterno.Text !="" && txtEmail.Text !="" && txtTelefono.Text !="" && txtCelular.Text!="" && txtDireccion.Text != "")
                        {
                            Cliente cliente = new Cliente();
                            cliente.Tipo_doc = txtTipodoc.Text;
                            cliente.Ruc = txtRuc.Text;
                            cliente.Dni = txtDni.Text;
                            cliente.Razon_social = txtRazonsocial.Text;
                            cliente.Numero_doc = txtNumerodoc.Text;
                            cliente.Nombre = txtNombre.Text;
                            cliente.ApellidoPaterno = txtApellidoPaterno.Text;
                            cliente.ApellidoMaterno = txtApellidoMaterno.Text;
                            cliente.Email = txtEmail.Text;
                            cliente.Telefono = txtTelefono.Text;
                            cliente.Celular = txtCelular.Text;
                            cliente.Direccion = txtDireccion.Text;
                            cliente.FechaRegistro = dateTimePicker1.Value;
                            int returnId = FCliente.Insertar(cliente);
                            if (returnId > 0)
                            {
                                FrmCliente_Load(null, null);
                                habilitarBotones(false);
                            }
                        }
                    }
                    else
                    {
                        Cliente cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(txtId.Text);
                        cliente.Tipo_doc = txtTipodoc.Text;
                        cliente.Ruc = txtRuc.Text;
                        cliente.Dni = txtDni.Text;
                        cliente.Razon_social = txtRazonsocial.Text;
                        cliente.Numero_doc = txtNumerodoc.Text;
                        cliente.Nombre = txtNombre.Text;
                        cliente.ApellidoPaterno = txtApellidoPaterno.Text;
                        cliente.ApellidoMaterno = txtApellidoMaterno.Text;
                        cliente.Email = txtEmail.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Celular = txtCelular.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.FechaRegistro = dateTimePicker1.Value;
                        int returnId = FCliente.Actualizar(cliente);
                        if(returnId > 0)
                        {
                            FrmCliente_Load(null, null);
                            habilitarBotones(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                    FrmCliente_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string valitarDatos()
        {
            string resultado = "";
            if (txtTipodoc.Text == "")
            {
                resultado = "El campo Tipo Doc está vacío";
                txtTipodoc.Focus();
            }
            //if (txtRuc.Text == "")
            //{
            //    resultado = "El campo Ruc está vacío";
            //    txtRuc.Focus();
            //}
            //if (txtDni.Text == "")
            //{
            //    resultado = "El campo Dni está vacío";
            //    txtDni.Focus();
            //}
            if (txtNumerodoc.Text == "")
            {
                resultado = "El campo N° Doc está vacío";
                txtNumerodoc.Focus();
            }
            if (txtRazonsocial.Text == "")
            {
                resultado = "El campo Razon Social está vacío";
                txtRazonsocial.Focus();
            }
            if (txtNombre.Text == "")
            {
                resultado = "El campo Nombre está vacío";
                txtNombre.Focus();
            }


            return resultado;
         }
        private static DataTable dt = new DataTable();
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            try
            {
                DataSet ds = FCliente.GetAll();
                dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
                dgvDatos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void mostrarOcultar(bool b)
        {
            txtTipodoc.Enabled = b;
            txtRuc.Enabled = b;
            txtDni.Enabled = b;
            txtRazonsocial.Enabled = b;
            txtNumerodoc.Enabled = b;
            txtNombre.Enabled = b;
            txtApellidoPaterno.Enabled = b;
            txtApellidoMaterno.Enabled = b;
            txtEmail.Enabled = b;
            txtTelefono.Enabled = b;
            txtCelular.Enabled = b;
            txtDireccion.Enabled = b;
            dateTimePicker1.Enabled = b;
        }
        public void habilitarBotones(bool b)
        {
            btnNuevo.Enabled = !b;
            btnEditar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = !b;
            btnCancelar.Enabled = b;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtTipodoc.Text="";
            txtRuc.Text="";
            txtDni.Text="";
            txtRazonsocial.Text="";
            txtNumerodoc.Text="";
            txtNombre.Text="";
            txtApellidoPaterno.Text="";
            txtApellidoMaterno.Text="";
            txtEmail.Text="";
            txtTelefono.Text="";
            txtCelular.Text="";
            txtDireccion.Text="";
            habilitarBotones(true);
            mostrarOcultar(true);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            FrmCliente_Load(null, null);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);
            mostrarOcultar(true);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FCliente.Eliminar(cliente);
                    if(returnId > 0) 
                    {
                        FrmCliente_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, talvez no hay proveedor registrado", "No se puede eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void asignarDatos()
        {
            if (dgvDatos.CurrentRow != null)
            {
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtTipodoc.Text = dgvDatos.CurrentRow.Cells["Tipo_doc"].Value.ToString();
                txtRuc.Text = dgvDatos.CurrentRow.Cells["Ruc"].Value.ToString();
                txtDni.Text = dgvDatos.CurrentRow.Cells["Dni"].Value.ToString();
                txtNumerodoc.Text = dgvDatos.CurrentRow.Cells["Numero_doc"].Value.ToString();
                txtRazonsocial.Text = dgvDatos.CurrentRow.Cells["Razon_social"].Value.ToString();
                txtNombre.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidoPaterno.Text = dgvDatos.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
                txtApellidoMaterno.Text = dgvDatos.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
                txtEmail.Text = dgvDatos.CurrentRow.Cells["Email"].Value.ToString();
                txtTelefono.Text = dgvDatos.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCelular.Text = dgvDatos.CurrentRow.Cells["Celular"].Value.ToString();
                txtDireccion.Text = dgvDatos.CurrentRow.Cells["Direccion"].Value.ToString();
                dateTimePicker1.Text = dgvDatos.CurrentRow.Cells["FechaRegistro"].Value.ToString();

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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones(true);
            mostrarOcultar(true);
        }
    }
}
