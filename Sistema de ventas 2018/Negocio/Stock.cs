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
        private Producto _productoId;

        public int Id
        {
            get{ return _id; }

            set{ _id = value;}
        }

        public Producto ProductoId
        {
            get { return _productoId; }

            set { _productoId = value; }
        }

        public int CantidadStock
        {
            get{ return _cantidadStock; }

            set { _cantidadStock = value;
            }
        }
        public Stock()
        {
            _productoId = new Producto();
        }
    }
}
