using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
     public class Inventario
    {      
        private int _id;
        private Producto _producto;
        private decimal _entrada;
        private decimal _salida;
        private decimal _stock;
        private int _detalleVentaId;
        private int _detalleCompraId;

        public int Id

        {
            get { return _id;}

            set  { _id = value; }
        }

        public Producto Producto
        {
            get { return _producto; }

            set{_producto = value;}
        }

        public decimal Entrada
        {
            get{return _entrada; }

            set {_entrada = value; }
        }

        public decimal Salida
        {
            get{ return _salida;}

            set{_salida = value; }
        }

        public decimal Stock
        {
            get{return _stock; }

            set{ _stock = value;
            }
        }

        public int DetalleVentaId
        {
            get {return _detalleVentaId;
            }

            set{_detalleVentaId = value;
            }
        }

        public int DetalleCompraId
        {
            get{ return _detalleCompraId;
            }

            set{ _detalleCompraId = value;}
        }

        public Inventario()
        {
            _producto = new Producto();
        }
    }
}
