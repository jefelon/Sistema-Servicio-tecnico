using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Negocio
{
    public class Usuario
    {
        private static int _id;
        private static string _nombre, _apellidos, _nombreUsuario, _contrasena,_tipo;

        public static int Id
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

        public static string Nombre
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
        public static string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public static string NombreUsuario
        {
            get
            {
                return _nombreUsuario;
            }

            set
            {
                _nombreUsuario = value;
            }
        }


        public static string Contrasena
        {
            get
            {
                return _contrasena;
            }

            set
            {
                _contrasena = value;
            }
        }

        public static string Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
            }
        }
    }
}
