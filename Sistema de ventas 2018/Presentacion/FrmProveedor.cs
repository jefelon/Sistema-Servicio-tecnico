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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    if (txtId.Text == "")
                    {
                        if (txtNombre.Text != "" && txtRuc.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "")
                        {
                            Proveedor proveedor = new Proveedor();
                            proveedor.Nombre = txtNombre.Text;
                            proveedor.Ruc = txtRuc.Text;
                            proveedor.Direccion = txtDireccion.Text;
                            proveedor.Telefono = txtTelefono.Text;
                            proveedor.Email = txtEmail.Text;
                            proveedor.FechaRegistro = dateTimePicker1.Value; 
                            int returnId = FProveedor.Insertar(proveedor);
                            if (returnId > 0)
                            {
                                FrmProveedor_Load(null, null);
                                habilitarBotones(false);
                            }

                        }
                    }
                    else
                    {
                        Proveedor  proveedor = new Proveedor();
                        proveedor.Id = Convert.ToInt32(txtId.Text);
                        proveedor.Nombre = txtNombre.Text;
                        proveedor.Ruc = txtRuc.Text;
                        proveedor.Direccion = txtDireccion.Text;
                        proveedor.Telefono = txtTelefono.Text;
                        proveedor.Email = txtEmail.Text;
                        proveedor.FechaRegistro = dateTimePicker1.Value; 
                        int returnId = FProveedor.Actualizar(proveedor);
                        if (returnId > 0)
                        {
                            FrmProveedor_Load(null, null);
                            habilitarBotones(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                    FrmProveedor_Load(null, null);
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
                resultado = "El campo está vacío";
                txtNombre.Focus();
            }           
            return resultado;
        }
        private static DataTable dt = new DataTable();

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            try {
                DataSet ds = FProveedor.GetAll();
                dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
                dgvDatos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void mostrarOcultar(bool b)
        {
            txtNombre.Enabled = b;
            txtNombre.Enabled = b;
            txtRuc.Enabled = b;
            txtDireccion.Enabled = b;
            txtTelefono.Enabled = b;
            txtEmail.Enabled = b;
            dateTimePicker1.Enabled = b;
        }
        private void habilitarBotones(bool b)
        {
            btnNuevo.Enabled = !b;
            btnEditar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = !b;
            btnCancelar.Enabled = b;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {//
            txtId.Text = "";
            txtNombre.Text = "";
            txtRuc.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            habilitarBotones(true);
            mostrarOcultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            FrmProveedor_Load(null, null);
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
                    Proveedor proveedor = new Proveedor();
                    proveedor.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    if(FProveedor.Eliminar(proveedor) > 0)
                    {
                        FrmProveedor_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar, talvez no hay proveedor registrado", "No se puede eliminar");
                    }
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
                txtRuc.Text = dgvDatos.CurrentRow.Cells["RUC"].Value.ToString();
                txtDireccion.Text = dgvDatos.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dgvDatos.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = dgvDatos.CurrentRow.Cells["Email"].Value.ToString();
                dateTimePicker1.Text = dgvDatos.CurrentRow.Cells["FechaRegistro"].Value.ToString();
                               
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
