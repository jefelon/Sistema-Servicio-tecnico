using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
    public class DetalleVenta
    {
        private int _id;
        private Venta _venta;
        private Producto _producto;
        private decimal _cantidad;
        private decimal _precioUnitario;
        private decimal _precioVenta;

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

        public Venta Venta
        {
            get
            {
                return _venta;
            }

            set
            {
                _venta = value;
            }
        }

        public Producto Producto
        {
            get
            {
                return _producto;
            }

            set
            {
                _producto = value;
            }
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

        public decimal PrecioUnitario
        {
            get
            {
                return _precioUnitario;
            }

            set
            {
                _precioUnitario = value;
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                return _precioVenta;
            }

            set
            {
                _precioVenta = value;
            }
        }
        public  DetalleVenta()
        {
            _venta = new Venta();
            _producto = new Producto();
        }
    }
}
