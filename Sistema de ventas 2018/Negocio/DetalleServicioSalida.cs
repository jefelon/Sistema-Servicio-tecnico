using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
       public class DetalleServicioSalida
    {
        
        private int _id;
        private Salida _salida;
        private Servicio _servicio;
        private decimal _precio,_cantidad;

        public int Id
        {
            get{ return _id;  }

            set {_id = value;}
        }

        public Salida Salida
        {
            get { return _salida; }

            set {_salida = value; }
        }

        public Servicio Servicio
        {
            get{return _servicio; }

            set { _servicio = value;}
        }

        public decimal Precio
        {
            get{return _precio; }

            set{ _precio = value; }
        }

        public decimal Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }

        public DetalleServicioSalida()
        {
            _salida = new Salida();
            _servicio = new Servicio();
        }
    }
}
