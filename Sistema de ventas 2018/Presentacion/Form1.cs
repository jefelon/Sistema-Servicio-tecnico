using FastReport;
using Sistema_de_ventas_2018.Negocio;
using Sistema_de_ventas_2018.Presentacion;
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

namespace Sistema_de_ventas_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if(Usuario.Tipo=="1")
            {

            }
            else if(Usuario.Tipo == "2")
            {
                btnTpv.Visible = false;
                clasificaciónToolStripMenuItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("No tiene privilegios");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria form = new FrmCategoria();
            form.Show();

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            FrmIngreso form = new FrmIngreso();
            form.Show();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            FrmSalida form = new FrmSalida();
            form.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipo form = new FrmEquipo();
            form.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompra form = new FrmCompra();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tipoDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumento form = new FrmTipoDocumento();
            form.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor form = new FrmProveedor();
            form.Show();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            FrmProveedor form = new FrmProveedor();
            form.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca form = new FrmMarca();
            form.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModelo form = new FrmModelo();
            form.Show();
        }
        

        private void btnTpv_Click(object sender, EventArgs e)
        {
            FrmVenta form = new FrmVenta();
            form.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto form = new FrmProducto();
            form.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicio form = new FrmServicio();
            form.Show();
        }

        private void unidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidadMedida form = new FrmUnidadMedida();
            form.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalida form = new FrmSalida();
            form.Show();
        }

        private void detalleProductoSaldiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleProductoSalida form = new FrmDetalleProductoSalida();
            form.Show();
        }

        private void detalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleServicioSalida form = new FrmDetalleServicioSalida();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente form = new FrmCliente();
            form.Show();
        }

        private void proveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProveedor form = new FrmProveedor();
            form.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta form = new FrmVenta();
            form.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompra form = new FrmCompra();
            form.Show();
        }

        private void ingresoEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngreso form = new FrmIngreso();
            form.Show();
        }

        private void salidaEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalida form = new FrmSalida();
            form.Show();
        }
        
        private void vistaVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmVenta_Vista form = new FrmVenta_Vista();
            form.Show();
        }

        private void comprasGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompra_Vista form = new FrmCompra_Vista();
            form.Show(); 
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report frmReporteProductos = new Report();
            frmReporteProductos.Load(@"Reportes/ReporteProductos.frx");
            frmReporteProductos.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
            frmReporteProductos.Show();
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report frmReporteVenta = new Report();
            frmReporteVenta.Load(@"Reportes/ReporteVentas.frx");
            frmReporteVenta.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
            frmReporteVenta.Show();
        }

        private void reporteComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report frmReporteCompra = new Report();
            frmReporteCompra.Load(@"Reportes/ReporteCompras.frx");
            frmReporteCompra.Dictionary.Connections[0].ConnectionString = ConfigurationManager.AppSettings.Get("connectionString");
            frmReporteCompra.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStock form = new FrmStock();
            form.Show();
        }

        private void equiposPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPendientes pendientes = new FrmPendientes();
            pendientes.Show();
        }
    }
}
