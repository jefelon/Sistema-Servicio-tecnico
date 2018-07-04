using Sistema_de_ventas_2018.Datos;
using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_2018.Presentacion
{
    public partial class FrmEquipo : Form
    {
        public FrmEquipo()
        {
            InitializeComponent();
        }
        DataTable dt2 = new DataTable();
        public void cargar_Modelo()
        {
            DataSet ds = FModelo.GetAll();
            dt2 = ds.Tables[0];
            cmbModelo.ValueMember = "Id";
            cmbModelo.DisplayMember = "Nombre";
            cmbModelo.DataSource = dt2;
        }
        DataTable dt3 = new DataTable();
        public void cargar_Marca()
        {
            DataSet ds = FMarca.GetAll();
            dt3 = ds.Tables[0];
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Nombre";
            cmbMarca.DataSource = dt3;
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
                        if (txtDescripcion.Text != "" && txtSerie.Text != "")
                        {
                            Equipo equipo = new Equipo();
                            equipo.Descripcion = txtDescripcion.Text;
                            equipo.Modelo.Id = Convert.ToInt32(cmbModelo.SelectedValue);
                            equipo.Serie = txtSerie.Text;
                            equipo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
                            int returId = FEquipo.Insertar(equipo);
                            if (returId > 0)
                            {
                                FrmEquipo_Load(null, null);
                                habilitarBotones(false);
                            }
                        }
                    }
                    else
                    {
                        Equipo equipo = new Equipo();
                        equipo.Id = Convert.ToInt32(txtId.Text);
                        equipo.Descripcion = txtDescripcion.Text;
                        equipo.Modelo.Id = Convert.ToInt32(cmbModelo.SelectedValue);
                        equipo.Serie = txtSerie.Text;
                        equipo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
                        int returnId = FEquipo.Actualizar(equipo);
                        if (returnId > 0)
                        {
                        
                            FrmEquipo_Load(null, null);
                            habilitarBotones(false);
                        }
                           
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                    FrmEquipo_Load(null, null);
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
            if (txtDescripcion.Text == "")
            {
                resultado = "El campo está vacio";
                txtDescripcion.Focus();
            }
            if(txtSerie.Text=="")
            {
                resultado = "El campo está vacío";
                txtSerie.Focus();
            }
            return resultado;
        }
        private static DataTable dt = new DataTable();
        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            cargar_Modelo();
            cargar_Marca();
            mostrarOcultar(false);
            try
            {
                DataSet ds = FEquipo.GetAll(); 
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
            txtDescripcion.Enabled = b;
            cmbModelo.Enabled = b;
            txtSerie.Enabled = b;
            cmbMarca.Enabled = b;
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
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            cmbModelo.Text = "";
            txtSerie.Text = "";
            cmbMarca.Text = "";
            habilitarBotones(true);
            mostrarOcultar(true);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            habilitarBotones(false);
            FrmEquipo_Load(null, null);
            
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
                    Equipo equipo = new Equipo();
                    equipo.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString()); 
                    if(FEquipo.Eliminar(equipo) > 0 )
                    {
                        FrmEquipo_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar, talvez no hay aquipos registrados", "No se puede eliminar");
                    }
                }
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDatos.CurrentRow !=null)
            {
               // si esta seleccionado algun dato obtenemos el id del dato para pasar al otro formulrion, para su respectiva edicion, en el otro form el texbox, su popiedad  modifier esta en publico, no es la manera mas correcta de hacerlo pero el mas facil
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtDescripcion.Text = dgvDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
                cmbModelo.Text = dgvDatos.CurrentRow.Cells["Modelo"].Value.ToString();
                txtSerie.Text = dgvDatos.CurrentRow.Cells["Serie"].Value.ToString();
                cmbMarca.Text = dgvDatos.CurrentRow.Cells["Marca"].Value.ToString();
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                // si esta seleccionado algun dato obtenemos el id del dato para pasar al otro formulrion, para su respectiva edicion, en el otro form el texbox, su popiedad  modifier esta en publico, no es la manera mas correcta de hacerlo pero el mas facil
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtDescripcion.Text = dgvDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
                cmbModelo.Text = dgvDatos.CurrentRow.Cells["Modelo"].Value.ToString();
                txtSerie.Text = dgvDatos.CurrentRow.Cells["Serie"].Value.ToString();
                cmbMarca.Text = dgvDatos.CurrentRow.Cells["Marca"].Value.ToString();

            }
        }
    }
}
