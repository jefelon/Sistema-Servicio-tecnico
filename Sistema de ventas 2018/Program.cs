using Sistema_de_ventas_2018.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_2018
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
                Application.Run(new Form1());
        }
    }
}
