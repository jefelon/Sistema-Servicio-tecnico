﻿using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Datos
{
    public class FUsuario
    {
        public static DataSet iniciarSesion(string sUsuario, string sContrasena)//Editar datos como enteros
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@NombreUsuario", SqlDbType.VarChar, 0, sUsuario),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, sContrasena),
                };
            return DBHelper.ExecuteDataSet("usp_Datos_FUsuario_IniciarSesion", dbParams);

        }
        public static DataSet Get(int iId)//Editar datos como enteros
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, iId)

                };
            return DBHelper.ExecuteDataSet("usp_Datos_FUsuario_Get", dbParams);

        }
        public static DataSet GetAll()//trae todos los clientes
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return DBHelper.ExecuteDataSet("usp_Datos_FUsuario_GetAll", dbParams);//procedimiento de la base de daatos que trae todos los registros

        }
        public static int InsertarUsuario(string sNombre, string sApellidos,  string sCelular, string sDireccion, string sDni, string sNombreUsuario, string sContrasena, string sTipo )

        {
            SqlParameter[] dbParams = new SqlParameter[]
                {//Id, Nombre, Apellidos, Dni, Direccion, Celular, NombreUsuario, Contrasena, Tipo
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,sNombre ),
                    DBHelper.MakeParam("@Apellidos", SqlDbType.VarChar, 0, sApellidos),
                    DBHelper.MakeParam("@Dni", SqlDbType.Decimal, 0, sDni),
                    DBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, sDireccion),
                    DBHelper.MakeParam("@Celular", SqlDbType.VarChar, 0,sCelular),
                    DBHelper.MakeParam("@NombreUsuario", SqlDbType.VarChar, 0, sNombreUsuario),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, sContrasena),
                    DBHelper.MakeParam("@Tipo", SqlDbType.VarChar, 0, sTipo)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUsuario_Insertar", dbParams));

        }

        public static int Insertar(Usuario usuario)

        {
            SqlParameter[] dbParams = new SqlParameter[]
                {//Id, Nombre, Apellidos, Dni, Direccion, Celular, NombreUsuario, Contrasena, Tipo
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,Usuario.Nombre),
                    DBHelper.MakeParam("@Apellidos", SqlDbType.VarChar, 0, Usuario.Apellidos),
                    DBHelper.MakeParam("@Dni", SqlDbType.NChar, 0,usuario.Dni),
                    DBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, usuario.Direccion),
                    DBHelper.MakeParam("@Celular", SqlDbType.NChar, 0,usuario.Celular),
                    DBHelper.MakeParam("@NombreUsuario", SqlDbType.VarChar, 0, Usuario.NombreUsuario),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, Usuario.Contrasena),
                    DBHelper.MakeParam("@Tipo", SqlDbType.VarChar, 0, Usuario.Tipo)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUsuario_Insertar", dbParams));
        }
        public static int Actualizar(Usuario usuario)//Como una clase est+atica no se puede modificar durante el modo de  ejecucion, pasamos sus atributos directamente
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, Usuario.Id),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,Usuario.Nombre),
                    DBHelper.MakeParam("@Apellidos", SqlDbType.VarChar, 0, Usuario.Apellidos),
                    DBHelper.MakeParam("@Dni", SqlDbType.Decimal, 0,usuario.Dni),
                    DBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, usuario.Direccion),
                    DBHelper.MakeParam("@Celular", SqlDbType.VarChar, 0,usuario.Celular),
                    DBHelper.MakeParam("@NombreUsuario", SqlDbType.VarChar, 0, Usuario.NombreUsuario),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, Usuario.Contrasena),
                    DBHelper.MakeParam("@Tipo", SqlDbType.VarChar, 0, Usuario.Tipo)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUsuario_Actualizar", dbParams));

        }

        public static int Eliminar(Usuario usuario)//Editar datos como enteros
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0,Usuario.Id)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUsuario_Eliminar", dbParams));

        }

        internal class Helper  //con esto nos aeguramos que ndie pueda hackear la contraseña ni descifrarlo en la base de datos...
        {
            public static string EncodePassword(string originalPassword)
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();

                byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
                byte[] hash = sha1.ComputeHash(inputBytes);

                return Convert.ToBase64String(hash);
            }
        }
    }
}
