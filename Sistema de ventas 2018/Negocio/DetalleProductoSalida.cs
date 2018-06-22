using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
       public class DetalleProductoSalida
    {
        private int _id;
        private Producto _producto;
        private Salida _salida;
        private decimal _precio,_cantidad;

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }

        public Producto Producto
        {
            get{return _producto;}

            set { _producto = value;}
        }

        public Salida Salida
        {
            get { return _salida; }

            set { _salida = value;}
        }

        public decimal Precio
        {
            get {return _precio; }

            set{_precio = value; }
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

        public DetalleProductoSalida()
        {
            _producto = new Producto();
            _salida = new Salida();
        }
    }
}
