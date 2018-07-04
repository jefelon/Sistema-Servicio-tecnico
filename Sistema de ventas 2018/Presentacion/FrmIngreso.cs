using FastReport;
using Sistema_de_ventas_2018.Datos;
using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_2018.Presentacion
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
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
                    Ingreso ingreso = new Ingreso();
                    // ingreso.Cliente.Id = Convert.ToInt32(txtClienteId.Text);
                    ingreso.FechaIngreso = dtpFechaIngreso.Value;
                    ingreso.ObservacionExterna = txtObservacionExterna.Text;
                    ingreso.ObservacionInterna = txtObservacionInterna.Text;
                    ingreso.MotivoIngreso = txtMotivoIngreso.Text;
                    ingreso.FechaProbableReparacion = dtpFechaProbableReparacion.Value;
                    ingreso.Adelanto = Convert.ToDecimal(txtAdento.Text);
                    ingreso.Estado = txtEstadoIngreso.Text;
                    ingreso.Cliente.Id = Convert.ToInt32(txtClienteId.Text);
                    ingreso.Equipo.Id = Convert.ToInt32(txtEquipoId.Text);
                    int returnId = FIngreso.Insertar(ingreso);
                    if (returnId > 0)
                    {
                        MessageBox.Show("Se registro correctamente el ingreso"+returnId.ToString());

                        txtId.Text = returnId.ToString();
                        lblNumero.Text = returnId.ToString();

                        Report frmComprobantes = new Report();
                        frmComprobantes.Load(@"Reportes/ReporteIngreso.frx");
                        frmComprobantes.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
                        frmComprobantes.SetParameterValue("Numero", returnId.ToString());
                        frmComprobantes.Show();

                        FrmIngreso_Load(null, null);
                    }
                }                  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string validarDatos()
        {//Id, Numero, FechaIngreso, ObservacionExterna, ObservacionInterna, MotivoIngreso, FechaProbableReparacion, Adelanto, Estado, ClienteId, EquipoId
            string resultado = "";
            if (txtObservacionExterna.Text == "")
            {
                resultado = "El campo ObservacioExt. está vacío";
                txtObservacionExterna.Focus();
            }
            if (txtObservacionInterna.Text == "")
            {
                resultado = "El campo ObservacionInt. está vacío";
                txtObservacionInterna.Focus();
            }
            if (txtAdento.Text == "")
            {
                resultado = "El campo Adelanto está vacío";
                txtAdento.Focus();
            }
            if (txtEstadoIngreso.Text == "")
            {
                resultado = "El campo Estado está vacío";
                txtEstadoIngreso.Focus();
            }
            return resultado;
        }
        DataTable dt1 = new DataTable();
        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            //try
            //{
            //    DataSet ds=FIngreso
            //}
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmCliente_Vista form = new FrmCliente_Vista();
            form.ShowDialog();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmEquipo_Vista form = new FrmEquipo_Vista();

            form.ShowDialog();
        }
        private void btnListaCliente_Click(object sender, EventArgs e)
        {
            FrmCliente_Vista form = new FrmCliente_Vista();
            form.ShowDialog();
            txtNombre.Text = form.nombre + form.apellido_paterno;
            txtDNI.Text = form.dni;
            txtDireccion.Text = form.direccion;
        }

        private void btnListaEquipo_Click(object sender, EventArgs e)
        {
            FrmListaEquipos form = new FrmListaEquipos();
            form.ShowDialog();
            txtDescripcion.Text = form.descripcion;
            txtMarca.Text = form.marca;
            txtModelo.Text = form.modelo;
        }
        public void mostrarOcultar(bool b)
        {
            //txtClienteId.Enabled = b;
            txtDescripcion.Enabled = b;
            txtDireccion.Enabled = b;
            txtNombre.Enabled = b;
            txtDNI.Enabled = b;
           // txtEquipoId.Enabled = b;
            txtEstadoIngreso.Enabled = b;
            txtObservacionInterna.Enabled = b;
            txtObservacionExterna.Enabled = b;
            txtMotivoIngreso.Enabled = b;
            txtModelo.Enabled = b;
            txtMarca.Enabled = b;
            txtAdento.Enabled = b;
            dtpFechaIngreso.Enabled = b;
            dtpFechaProbableReparacion.Enabled = b;
            btnCargarCliente.Enabled = b;
            btnCargarEquipo.Enabled = b;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtClienteId.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtEquipoId.Text = "";
            txtObservacionInterna.Text = "";
            txtObservacionExterna.Text = "";
            txtMotivoIngreso.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtAdento.Text = "";
            lblNumero.Text = "";
            //dtpFechaIngreso.Text = "";
            dtpFechaProbableReparacion.Text = "";
            mostrarOcultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                Report frmComprobantes = new Report();
                frmComprobantes.Load(@"Reportes/ReporteIngreso.frx");
                frmComprobantes.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
                frmComprobantes.SetParameterValue("Numero", Convert.ToInt32(txtId.Text));
                frmComprobantes.Show();
            }

        }
    }
}
