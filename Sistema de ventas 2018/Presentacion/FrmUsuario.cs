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

            

            if (Usuario.Tipo == "ADMINISTRADOR")
            {
                DataSet ds1 = FUsuario.GetAll();
                dt1 = ds1.Tables[0];
                dgvDatos.DataSource = dt1;
                dgvDatos.Columns["Id"].Visible = false;
            }
            else if (Usuario.Tipo == "VENDEDOR")
            {
                DataSet ds1 = FUsuario.Get(Usuario.Id);
                dt1 = ds1.Tables[0];
                dgvDatos.DataSource = dt1;
                dgvDatos.Columns["Id"].Visible = false;

                cmbTipo.Items.Clear();
                cmbTipo.Items.Add("VENDEDOR");
<<<<<<< HEAD
                cmbTipo.SelectedIndex = 0;

=======

                btnNuevo.Enabled = false;
                btnEliminar.Enabled = false;
>>>>>>> 138b88afa8752cb410cede66b7fdfbcaea97869d
            }
            else
            {
                MessageBox.Show("No tiene privilegios");
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

          
            string contrasena = txtContrasena.Text.Trim();
           
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    if (txtId.Text == "")
                    {
                        string usuariot = txtNombreUsuario.Text;
                        string contrasenat = txtContrasena.Text;
                        string hash = FUsuario.Helper.EncodePassword(string.Concat(usuariot, contrasenat));

                        int retunrId = FUsuario.Insertar(txtNombre.Text, txtApellidos.Text, txtDni.Text,txtDierccion.Text,txtCelular.Text,txtNombreUsuario.Text,hash,cmbTipo.Text);
                        if (retunrId > 0)
                        {
                            MessageBox.Show("Usuario "+ txtNombreUsuario.Text+" Fué insertado correctamente");
                            FrmUsuario_Load(null, null);
                            habilitarBotones(false);
                        }

                    }
                    else
                    {                                       
                        string usuariot = txtNombreUsuario.Text;
                        string contrasenat = txtContrasena.Text;
                        string hash = FUsuario.Helper.EncodePassword(string.Concat(usuariot, contrasenat));

                        int returnId = FUsuario.Actualizar(Convert.ToInt32(txtId.Text),txtNombre.Text, txtApellidos.Text, txtDni.Text, txtDierccion.Text, txtCelular.Text, txtNombreUsuario.Text, hash, cmbTipo.Text);
                        if(returnId > 0)
                        {
                            MessageBox.Show("Los datos del usuario " + txtNombreUsuario.Text + " se editaron correctamente");
                            FrmUsuario_Load(null, null);
                            habilitarBotones(false);
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
            if (txtNombreUsuario.Text == "")
            {
                resultado = "El campo Usuario está vacío";
                txtNombreUsuario.Focus();
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
           
        }
        private void habilitarBotones(bool b)
        {
            btnCancelar.Enabled = b;
            btnEditar.Enabled = !b;
            btnEliminar.Enabled = !b;
            btnGuardar.Enabled = b;

            if (Usuario.Tipo=="ADMINISTRADOR")
            {
                btnNuevo.Enabled = !b;
            }
            else if (Usuario.Tipo == "VENDEDOR")
            {
                btnNuevo.Enabled = false;
                btnEliminar.Enabled = false;
            }
           
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
            txtContrasena.Text = "";
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
                        MessageBox.Show("Eliminado");
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
                txtContrasena.Text = "***********";
                cmbTipo.Text = dgvDatos.CurrentRow.Cells["Tipo"].Value.ToString();
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
