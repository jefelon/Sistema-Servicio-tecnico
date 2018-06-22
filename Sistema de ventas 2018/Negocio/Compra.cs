using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
       public class Compra
    {
        private int _id;
        private Proveedor _proveedor;
        private int _usuario;
        private TipoDocumento _tipoDocumento;
        private string _nro_compronbante;
        private DateTime _fecha;

        public int Id
        {
            get { return _id;   }

            set { _id = value;}
        }

        public Proveedor Proveedor
        {
            get { return _proveedor;  }

            set { _proveedor = value; }
        }

        public int Usuario
        {
            get{return _usuario;}

            set {_usuario = value; }
        }

        public TipoDocumento TipoDocumento
        {
            get{ return _tipoDocumento; }

            set { _tipoDocumento = value;}
        }

        public string Nro_compronbante
        {
            get { return _nro_compronbante; }

            set { _nro_compronbante = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha;}

            set{ _fecha = value;}
        }
        public Compra()
        {
            _proveedor = new Proveedor();
            _tipoDocumento = new TipoDocumento();
        }

    }
}
