using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
     public class Servicio
    {
        private int _id;
        private string _descripcion;
        private decimal _precio;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                _precio = value;
            }
        }
    }
}
