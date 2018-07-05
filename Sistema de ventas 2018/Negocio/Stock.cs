using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
       public class Stock
    {
        private int _id;
        private int _cantidadStock;
        private Producto _producto;

        public int Id
        {
            get{ return _id; }

            set{ _id = value;}
        }

        public Producto Producto
        {
            get { return _producto; }

            set { _producto = value; }
        }

        public int CantidadStock
        {
            get{ return _cantidadStock; }

            set { _cantidadStock = value;
            }
        }
        public Stock()
        {
            _producto = new Producto();
        }
    }
}
