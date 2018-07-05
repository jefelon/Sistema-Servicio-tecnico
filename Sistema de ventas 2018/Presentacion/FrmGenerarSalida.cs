using Sistema_de_ventas_2018.Negocio;
using Sistema_de_ventas_2018.Datos;
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
    public partial class FrmGenerarSalida : Form
    {
        public FrmGenerarSalida()
        {
            InitializeComponent();
        }

        public int idSalida, ingresoId;//variables
        private void FrmGenerarSalida_Load(object sender, EventArgs e)
        {
                Salida salida = new Salida();//instanciamo nuestra clase Salida para rellenarle sus atributos
                salida.Numero = idSalida;//validar el campo en el formulario
                salida.FechaSalida = DateTime.Now.Date;
                salida.Diagnostico = "";
                salida.Estado = "---";
                salida.Ingreso.Id = ingresoId;
              int returnId = FSalida.Insertar(salida);//ejecutamos el procedimiento para Insertar
              if (returnId > 0)
              {
                    idSalida = returnId;//igualamos variable
                    lblNumeroSalida.Text = returnId.ToString();
              }          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();//cierra el formulario
        }
    }
}
