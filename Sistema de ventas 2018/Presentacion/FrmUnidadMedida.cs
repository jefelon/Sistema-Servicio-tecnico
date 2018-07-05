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
    public partial class FrmUnidadMedida : Form
    {
        public FrmUnidadMedida()
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
                        if (txtNombre.Text != "")
                        {
                            UnidadMedida unidadmedida = new UnidadMedida();
                            unidadmedida.Nombre = txtNombre.Text;
                            int returnId = FUnidadMedida.Insertar(unidadmedida);
                            if (returnId > 0)
                            {
                                FrmUnidadMedida_Load(null, null);
                                habilitarBotones(false);
                            }
                        }
                    }
                    else
                    {
                        UnidadMedida unidadmedida = new UnidadMedida();
                        unidadmedida.Id = Convert.ToInt32(txtId.Text);
                        unidadmedida.Nombre = txtNombre.Text;
                        int returnId = FUnidadMedida.Actualizar(unidadmedida);
                        if (returnId > 0)
                        {
                            FrmUnidadMedida_Load(null, null);
                            habilitarBotones(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                    FrmUnidadMedida_Load(null, null);
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

        private void FrmUnidadMedida_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            
                DataSet ds = FUnidadMedida.GetAll();
                dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
                dgvDatos.Columns["Id"].Visible = false;
            
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
            FrmUnidadMedida_Load(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);
            mostrarOcultar(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    UnidadMedida unidadmedida = new UnidadMedida();
                    unidadmedida.Id = Convert.ToInt32(txtId.Text);
                    int returnId = FUnidadMedida.Eliminar(unidadmedida);
                    if (returnId > 0)
                    {
                        FrmUnidadMedida_Load(null, null);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar, talvez no hay Unidad_Medida registrada", "No se puede eliminar");
                    }
                }
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
