using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
        public class Salida
    {
        private int _id;
        private int _numero;
        private DateTime _fechaSalida;
        private string _diagnostico;
        private string _estado;
        private Ingreso _ingreso;

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }

        public int Numero
        {
            get { return _numero; }

            set { _numero = value; }
        }

        public DateTime FechaSalida
        {
            get { return _fechaSalida; }

            set { _fechaSalida = value; }
        }

        public string Diagnostico
        {
            get { return _diagnostico; }

            set { _diagnostico = value; }
        }

        public string Estado
        {
            get { return _estado; }

            set { _estado = value; }
        }

        public Ingreso Ingreso
        {
            get
            {
                return _ingreso;
            }

            set
            {
                _ingreso = value;
            }
        }

        public Salida ()
        {
            _ingreso = new Ingreso();
        }
    }
}
