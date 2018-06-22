using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
    public class Producto
    {
        //Id, Codigo, Nombre, PrecioCompra, PrecioVenta, StockMinimo, StockMaximo, MarcaId, ModeloId, UnidadMedidaId, CategoriaId, ProveedorId, Ubicacion, FechaRegistro
        private int _id;
        private Marca _marca;
        private Modelo _modelo;
        private UnidadMedida _unidadMedida;
        private Categoria _categoria;
        private Proveedor _proveedor;
        private string _nombre, _ubicacion, _codigo;
        private double _precioCompra, _precioVenta, _stockMaximo, _stockMinimo;
        private DateTime _fechaRegistro;
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

        public Marca Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public Modelo Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        public UnidadMedida UnidadMedida
        {
            get
            {
                return _unidadMedida;
            }

            set
            {
                _unidadMedida = value;
            }
        }

        public Categoria Categoria
        {
            get
            {
                return _categoria;
            }

            set
            {
                _categoria = value;
            }
        }

        public Proveedor Proveedor
        {
            get
            {
                return _proveedor;
            }

            set
            {
                _proveedor = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Ubicacion
        {
            get
            {
                return _ubicacion;
            }

            set
            {
                _ubicacion = value;
            }
        }

        public string Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public double PrecioCompra
        {
            get
            {
                return _precioCompra;
            }

            set
            {
                _precioCompra = value;
            }
        }

        public double PrecioVenta
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

        public double StockMaximo
        {
            get
            {
                return _stockMaximo;
            }

            set
            {
                _stockMaximo = value;
            }
        }

        public double StockMinimo
        {
            get
            {
                return _stockMinimo;
            }

            set
            {
                _stockMinimo = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                return _fechaRegistro;
            }

            set
            {
                _fechaRegistro = value;
            }
        }

        public Producto ()
        {
           _marca=new Marca();
           _modelo = new Modelo() ;
           _unidadMedida = new UnidadMedida();
           _categoria = new Categoria();
           _proveedor = new Proveedor();
        }
    }
}
