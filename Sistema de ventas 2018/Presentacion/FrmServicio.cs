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
    public partial class FrmServicio : Form
    {
        public FrmServicio()
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
                        Servicio servicio = new Servicio();
                        servicio.Descripcion = txtDescripcion.Text;
                        servicio.Precio = Convert.ToDecimal(txtPrecio.Text);
                        int returnId = FServicio.Insertar(servicio);
                        if (returnId >0)
                        {
                            FrmServicio_Load(null, null);
                            habilitarBotones(false);
                        } 
                    }
                    else
                    {
                        Servicio servicio = new Servicio();
                        servicio.Id = Convert.ToInt32(txtId.Text);
                        servicio.Descripcion = txtDescripcion.Text;
                        servicio.Precio = Convert.ToDecimal(txtPrecio.Text);
                        int returnId = FServicio.Actualizar(servicio);
                        if (returnId > 0)
                        {
                            FrmServicio_Load(null, null);
                            habilitarBotones(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                    FrmServicio_Load(null, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string validarDatos()
        {
            string resultado = "";
            if (txtDescripcion.Text == "")
            {
                resultado = "El campo Descripcio está vacío";
                txtDescripcion.Focus();
            }
            if (txtPrecio.Text == "")
            {
                resultado = "El campo Precio está vacío";
            }
            return resultado;
        }
        DataTable dt1 = new DataTable();

        private void FrmServicio_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            try
            {
                DataSet ds= FServicio.GetAll();
                dt1 = ds.Tables[0];
                dgvDatos.DataSource = dt1;
                dgvDatos.Columns["Id"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        
        }
        public void mostrarOcultar(bool b)
        {
            txtDescripcion.Enabled = b;
            txtPrecio.Enabled = b;
        }
        public void habilitarBotones(bool b)
        {
            btnCancelar.Enabled = b;
            btnEditar.Enabled = !b;
            btnEliminar.Enabled = !b;
            btnNuevo.Enabled = !b;
            btnGuardar.Enabled = b;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            habilitarBotones(true);
            mostrarOcultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            FrmServicio_Load(null, null);
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
                if(MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminado",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Servicio servicio = new Servicio();
                    servicio.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FServicio.Eliminar(servicio);
                    if (returnId > 0)
                    {
                        FrmServicio_Load(null,null);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, talvez no hay modelo registrado", "No se puede eliminar");
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
                txtDescripcion.Text = dgvDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgvDatos.CurrentRow.Cells["Precio"].Value.ToString();
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
