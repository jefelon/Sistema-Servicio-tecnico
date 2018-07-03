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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        DataTable dt1 = new DataTable();
        private void FrmUsuario_Load(object sender, EventArgs e)
        {

            mostrarOcultar(false);
            cbTipo.Items[1] = "Administrador";
            cbTipo.Items[2] = "Usuario";
            DataSet ds1 = FUsuario.GetAll();
            dt1 = ds1.Tables[0];
            dgvDatos.DataSource = dt1;
            dgvDatos.Columns["Id"].Visible = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

          
            string contrasena = txtContrasena.Text.Trim();
           
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {//Nombre, Apellidos,Dni, Direccion, Celular, NombreUsuario, Contrasena, Tipo
                    if (txtId.Text == "")
                    {
                        Usuario usuario = new Usuario();
                        Usuario.Nombre = txtNombre.Text;
                        Usuario.Apellidos = txtApellidos.Text;
                        usuario.Dni = Convert.ToDecimal(txtDni.Text);
                        usuario.Direccion = txtDierccion.Text;
                        usuario.Celular = Convert.ToInt32(txtCelular.Text);
                        Usuario.NombreUsuario = txtNombreUsuario.Text;
                        Usuario.Contrasena = txtContrasena.Text;
                        string hash = FUsuario.Helper.EncodePassword(string.Concat(contrasena));
                        Usuario.Tipo = txtTipo.Text;
                        int retunrId = FUsuario.Insertar(usuario);
                        if (retunrId > 0)
                        {
                            FrmUsuario_Load(null, null);
                        }
                    }
                    else
                    {
                        Usuario usuario = new Usuario();
                        Usuario.Id = Convert.ToInt32(txtId.Text);
                        Usuario.Nombre = txtNombre.Text;
                        Usuario.Apellidos = txtApellidos.Text;
                        usuario.Dni = Convert.ToDecimal(txtDni.Text);
                        usuario.Direccion = txtDierccion.Text;
                        usuario.Celular = Convert.ToInt32(txtCelular.Text);
                        Usuario.NombreUsuario = txtNombreUsuario.Text;
                        Usuario.Contrasena = txtContrasena.Text;
                        Usuario.Tipo = txtTipo.Text;
                        int returnId = FUsuario.Actualizar(usuario);
                        if(returnId > 0)
                        {
                            FrmUsuario_Load(null, null);
                        }
                    }            
                    
                }
                else
                {
                    {
                       MessageBox.Show("Error: \n" + sResultado);
                    }
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
            if (txtNombre.Text == "")
            {
                resultado = "El campo Nombre está vacío";
                txtNombre.Focus();       
            }
            if (txtApellidos.Text == "")
            {
                resultado = "El campo Apellidos está vacío";
                txtNombre.Focus();
            }
            if (txtDni.Text == "")
            {
                resultado = "El campo Dni está vacío";
                txtDni.Focus();
            }
            if (txtDierccion.Text == "")
            {
                resultado = "El campo Direccióin está vacío";
                txtDierccion.Focus();
            }
            if (txtCelular.Text == "")
            {
                resultado = "El campo Celular está vacío";
                txtCelular.Focus();
            }
            if (txtNombreUsuario.Text == "")
            {
                resultado = "El campo Usuario está vacío";
                txtNombreUsuario.Focus();
            }
            //if (txtContrasena.Text == "")
            //{
            //    resultado = "El campo Contraseña está vacío";
            //    txtContrasena.Focus();
            //}
            if (txtTipo.Text == "")
            {
                resultado = "El campo Tipo está vacío";
                txtTipo.Focus();
            }
            return resultado;
        }
        private void mostrarOcultar(bool b)
        {
            txtApellidos.Enabled = b;
            txtCelular.Enabled = b;
            txtContrasena.Enabled = b;
            txtDierccion.Enabled = b;
            txtDni.Enabled = b;
            txtNombre.Enabled = b;
            txtNombreUsuario.Enabled = b;
            txtTipo.Enabled = b;
        }
        private void habilitarBotones(bool b)
        {
            btnCancelar.Enabled = b;
            btnEditar.Enabled = !b;
            btnEliminar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnNuevo.Enabled = !b;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtApellidos.Text = "";
            txtCelular.Text = "";
            txtContrasena.Text = "";
            txtDierccion.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            txtNombreUsuario.Text = "";
            txtTipo.Text = "";
            mostrarOcultar(true);
            habilitarBotones(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            FrmUsuario_Load(null, null);
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
                if(MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminado",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Usuario usuario = new Usuario();
                    Usuario.Id =Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FUsuario.Eliminar(usuario);
                    if(returnId > 0)
                    {
                        FrmUsuario_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, talvez no hay modelo registrado", "No se puede eliminar");
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
                txtNombre.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = dgvDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtDni.Text = dgvDatos.CurrentRow.Cells["Dni"].Value.ToString();
                txtDierccion.Text = dgvDatos.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCelular.Text = dgvDatos.CurrentRow.Cells["Celular"].Value.ToString();
                txtNombreUsuario.Text = dgvDatos.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                txtTipo.Text = dgvDatos.CurrentRow.Cells["Tipo"].Value.ToString();
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
    }
}
