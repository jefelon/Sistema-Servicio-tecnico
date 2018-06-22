using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
   public class Proveedor
    {
        
        private int _id; string _nombre; string _ruc; string _direccion; string _telefono; string _email; DateTime _fecharegistro;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Ruc
        {
            get { return _ruc; }
            set { _ruc = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public DateTime FechaRegistro
        {
            get { return _fecharegistro; }
            set { _fecharegistro = value; }
        }
    }
}
