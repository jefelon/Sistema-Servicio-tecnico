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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void IniciarSesion()
        {
            try
            {
                string usuario = txtNombreUsuario.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();
                string hash = FUsuario.Helper.EncodePassword(string.Concat(usuario, contrasena));

                DataSet ds = FUsuario.iniciarSesion(usuario, hash);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario no existe. Digitar correctamente el usuario y/o contraseña.", "ERROR DE INICIO DE SECION");
                }
                if (dt.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    Usuario.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    Usuario.Nombre = dt.Rows[0]["Nombre"].ToString();
                    Usuario.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                    Usuario.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                    Usuario.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                    Usuario.Tipo = dt.Rows[0]["Tipo"].ToString();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            //else{
            //    this.DialogResult = DialogResult.Abort;
            //}
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}
