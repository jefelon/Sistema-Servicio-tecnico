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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
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
                        if (txtNombre.Text != "")
                        {
                            Marca marca = new Marca();
                            marca.Nombre = txtNombre.Text;
                            int returnId = FMarca.Insertar(marca);
                            if (returnId > 0)
                            {
                                FrmMarca_Load(null, null);
                                habilitarBotones(false);
                            }
                        }
                    }
                    else
                    {
                        Marca marca = new Marca();
                        marca.Id = Convert.ToInt32(txtId.Text);
                        marca.Nombre = txtNombre.Text;
                        int returId = FMarca.Actualizar(marca);
                        if (returId > 0)
                        {
                            FrmMarca_Load(null, null);
                            habilitarBotones(false);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                    FrmMarca_Load(null, null);
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
            return resultado;
        }
        private static DataTable dt = new DataTable();

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            try
            {
                DataSet ds = FMarca.GetAll();
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
            txtNombre.Enabled = b;
        }
        public void habilitarBotones(bool b)
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
            txtNombre.Text = "";
            habilitarBotones(true);
            mostrarOcultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            FrmMarca_Load(null, null);
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
                    Marca marca = new Marca();
                    marca.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FMarca.Eliminar(marca);
                    if(returnId > 0)
                    {
                        FrmMarca_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar, talvez no hay marca registrada", "No se puede eliminar");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void asignarDatos()
        {
            if (dgvDatos.CurrentRow != null)
            {
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
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
       
    }
}