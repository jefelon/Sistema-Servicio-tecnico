using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
       public class DetalleCompra
    {
        private int _id;
        private Compra _compra;
        private Producto _producto;
        private decimal _cantidad;
        private decimal _precioUnitario;
       // private Conversion _conversion;

        public int Id
        {
            get{return _id;}

            set {_id = value; }
        }

        public Compra Compra
        {
            get {return _compra;}

            set{ _compra = value; }
        }

        public Producto Producto
        {
            get{ return _producto; }

            set{ _producto = value;}
        }

        public decimal Cantidad
        {
            get {return _cantidad; }

            set { _cantidad = value;}
        }

        public decimal PrecioUnitario
        {
            get{ return _precioUnitario;}

            set {_precioUnitario = value;
            }
        }

        //public Conversion Conversion
        //{
        //    get { return _conversion; }

        //    set {  _conversion = value; }
        //}
        public DetalleCompra()
        {
            _compra = new Compra();
            _producto = new Producto();
           // _conversion = new Conversion();
        }
    }
}
