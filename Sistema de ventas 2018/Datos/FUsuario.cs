using Sistema_de_ventas_2018.Negocio;
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

        public static int Insertar(string nombre,string apellidos, string dni, string direccion, string celular, string nombreUsuario, string contrasena, string tipo)

        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,nombre),
                    DBHelper.MakeParam("@Apellidos", SqlDbType.VarChar, 0, apellidos),
                    DBHelper.MakeParam("@Dni", SqlDbType.NChar, 0,dni),
                    DBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, direccion),
                    DBHelper.MakeParam("@Celular", SqlDbType.NChar, 0,celular),
                    DBHelper.MakeParam("@NombreUsuario", SqlDbType.VarChar, 0, nombreUsuario),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, contrasena),
                    DBHelper.MakeParam("@Tipo", SqlDbType.VarChar, 0, tipo)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUsuario_Insertar", dbParams));
        }
        public static int Actualizar(int id,string nombre, string apellidos, string dni, string direccion, string celular, string nombreUsuario, string contrasena, string tipo)//Como una clase est+atica no se puede modificar durante el modo de  ejecucion, pasamos sus atributos directamente
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, id),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,nombre),
                    DBHelper.MakeParam("@Apellidos", SqlDbType.VarChar, 0, apellidos),
                    DBHelper.MakeParam("@Dni", SqlDbType.NChar, 0,dni),
                    DBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, direccion),
                    DBHelper.MakeParam("@Celular", SqlDbType.NChar, 0,celular),
                    DBHelper.MakeParam("@NombreUsuario", SqlDbType.VarChar, 0, nombreUsuario),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, contrasena),
                    DBHelper.MakeParam("@Tipo", SqlDbType.VarChar, 0, tipo)
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
