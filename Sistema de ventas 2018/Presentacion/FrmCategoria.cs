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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "") //todo bien
                {
                    if ( txtId.Text=="")
                    {

                   
                        if (txtDescripcion.Text != "")
                        {
                            Categoria categoria = new Categoria();// instanciamos a la clace Categoria 
                            categoria.Descripcion = txtDescripcion.Text;//validamos el campo del formulario

                            int returnId = FCategoria.Insertar(categoria);//insertamos la instanciacion con la clace  FCategoria 
                            if (returnId > 0)
                            {

                                FrmCategoria_Load(null,null);
                            }
                        }
                    }
                    else
                    {  
                         Categoria categoria = new Categoria();//instanciamos a la clace Categoria 
                        categoria.Id = Convert.ToInt32(txtId.Text);//validamos los campo de formulario
                        categoria.Descripcion = txtDescripcion.Text;
                         int returnId = FCategoria.Actualizar(categoria);//Actualizamos la instanciacion con la clace  FCategoria 
                        if (returnId > 0)
                         {
                             FrmCategoria_Load(null, null);
                         }                     
                    }
                }
                else
                {
                    MessageBox.Show("Error: \n" + sResultado);
                }//fin validacion datos
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        public string validarDatos()//validamos todos los campos del formulario, para que no se registren vacios 
        {
            string resultado = "";
            if (txtDescripcion.Text == "")
            {
                resultado = "El nombre está vacio";
                txtDescripcion.Focus();
            }
            return resultado;// retornamos el resultado
        }

        private static DataTable dt = new DataTable(); //variable para crear un tabla
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            //una consulta a la base de datos siempre trataremos de omar el control, por si pasa algun error y se cierre la aplicación
            try
            {
                DataSet ds = FCategoria.GetAll();//creamos un dataset, un contenedor de datos y hacemos una consulta con la clase FCategoria y su método GetAll
                dt = ds.Tables[0]; //asignamos los datos del datased a la tabla
                dgvDatos.DataSource = dt; //propiamente dicho al datagridview le pasamos los datos de la tabla
                dgvDatos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void mostrarOcultar(bool b)
        {

            txtDescripcion.Enabled = b;//habilitando el metodo
        }

        private void habilitarBotones(bool b)//habilitamos los botones del formulariocone le metodo
        {
            btnNuevo.Enabled = b;
            btnEditar.Enabled = b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = !b;
            btnCancelar.Enabled = b;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            habilitarBotones(true);//el metodo habilitarBotones es verdadera 
            mostrarOcultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)//botones de
        {
            habilitarBotones(true);//el metodo habilitarBotones es verdadera 
            mostrarOcultar(true);//el metodo mostrarOcultar es verdadera 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);//el metodo habilitarBotones es verdadera
            mostrarOcultar(true);//el metodo mostrarOcultar es verdadera 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados?", "Eliminando...",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    Categoria categoria = new Categoria();// instanciamo nuestra clase para rellenarle sus atributos
                    categoria.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());// para eliminar solo le pasaremos su atributo id

                    if (FCategoria.Eliminar(categoria) > 0)// Ejecutamos el procedimiento almacenado para eliminar, si se pudo eliminar... recargamos el formulario
                    {
                        FrmCategoria_Load(null, null);//el formulario es nulo
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar, talvez hay productos en esta categoría", "No se puede eliminar");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                //si esta seleccionado algun dato obtenemos el id del dato para pasar al otro formularion, para su respectiva edicion, en el otro form el texbox, su propiedad  modifier esta en publico, no es la manera mas correcta de hacerlo pero el mas facil
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtDescripcion.Text = dgvDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                //si esta seleccionado algun dato obtenemos el id del dato para pasar al otro formularion, para su respectiva edicion, en el otro form el texbox, su propiedad  modifier esta en publico, no es la manera mas correcta de hacerlo pero el mas facil
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtDescripcion.Text = dgvDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }
    }
}
