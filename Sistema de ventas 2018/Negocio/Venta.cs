using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
        public class Venta
    {
        //Id, ClienteId, UsuarioId, TipoDocumentoId, Fecha, NumeroDocumento
        private  int _id;
        private Cliente _cliente;
        private int _usuarioId;
        private TipoDocumento _tipoDocumentoId;
        private DateTime _fecha;
        private string _serie;
        private  int _numeroDocumento;

        public  int Id
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

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }

            set
            {
                _cliente = value;
            }
        }
        public int UsuarioId
        {
            get { return _usuarioId; }
            set { _usuarioId = value; }
        }

        public TipoDocumento TipoDocumento
        {
            get
            {
                return _tipoDocumentoId;
            }

            set
            {
                _tipoDocumentoId = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        public int NumeroDocumento
        {
            get
            {
                return _numeroDocumento;
            }

            set
            {
                _numeroDocumento = value;
            }
        }

        public string Serie
        {
            get
            {
                return _serie;
            }

            set
            {
                _serie = value;
            }
        }

        public Venta()
        {
            _cliente = new Cliente();
            _tipoDocumentoId = new TipoDocumento();
        }
                
    }
}
