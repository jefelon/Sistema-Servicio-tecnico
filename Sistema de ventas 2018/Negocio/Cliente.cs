using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
    public class Cliente
    {
        private int _id; string _tipo_doc; string _ruc; string _dni; string _Numero_doc; string _razon_social; string _nombre; string _apellidopaterno; string _apellidomaterno; string _email; string _telefono; string _celular; string _direccion; DateTime _fecharegistro;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        } 
        public string Tipo_doc
        {
            get { return _tipo_doc; }
            set { _tipo_doc = value; }
        }
        public string Ruc
        {
            get { return _ruc; }
            set { _ruc = value; }
        }
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Numero_doc
        {
            get { return _Numero_doc; }
            set { _Numero_doc = value; }
        }
        public string Razon_social
        {
            get { return _razon_social; }
            set { _razon_social = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string ApellidoPaterno
        {
            get { return _apellidopaterno; }
            set { _apellidopaterno = value; }
        }
        public string ApellidoMaterno
        {
            get { return _apellidomaterno; }
            set { _apellidomaterno = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public DateTime FechaRegistro
        {
            get { return _fecharegistro; }
            set { _fecharegistro = value; }
        }
    }
}
