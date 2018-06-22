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
        public static int Insertar(string sUsuario, string sContrasena, string sNombre, string sApellidoPaterno, string sApellidoMaterno, string sEmail, string sTelefono, string sCelular, string sDireccion, string sDni, string sRol)//Como una clase est+atica no se puede modificar durante el modo de  ejecucion, pasamos sus atributos directamente
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Usuario", SqlDbType.VarChar, 0, sUsuario),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, sContrasena),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,sNombre ),
                    DBHelper.MakeParam("@ApellidoPaterno", SqlDbType.VarChar, 0, sApellidoPaterno),
                    DBHelper.MakeParam("@ApellidoMaterno", SqlDbType.VarChar, 0, sApellidoMaterno),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, sEmail),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0,sTelefono),
                    DBHelper.MakeParam("@Celular", SqlDbType.VarChar, 0,sCelular),
                    DBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, sDireccion),
                    DBHelper.MakeParam("@Dni", SqlDbType.Decimal, 0, sDni),
                    DBHelper.MakeParam("@Rol", SqlDbType.VarChar, 0, sRol)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUsuario_Insertar", dbParams));

        }
        public static int Actualizar(int iId, string sUsuario, string sContrasena, string sNombre, string sApellidoPaterno, string sApellidoMaterno, string sEmail, string sTelefono, string sCelular, string sDireccion, string sDni, string sRol)//Como una clase est+atica no se puede modificar durante el modo de  ejecucion, pasamos sus atributos directamente
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, iId),
                    DBHelper.MakeParam("@Usuario", SqlDbType.VarChar, 0, sUsuario),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, sContrasena),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0,sNombre ),
                    DBHelper.MakeParam("@ApellidoPaterno", SqlDbType.VarChar, 0, sApellidoPaterno),
                    DBHelper.MakeParam("@ApellidoMaterno", SqlDbType.VarChar, 0, sApellidoMaterno),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, sEmail),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0,sTelefono),
                    DBHelper.MakeParam("@Celular", SqlDbType.VarChar, 0,sCelular),
                    DBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, sDireccion),
                    DBHelper.MakeParam("@Dni", SqlDbType.Decimal, 0, sDni),
                    DBHelper.MakeParam("@Rol", SqlDbType.VarChar, 0, sRol)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUsuario_Actualizar", dbParams));

        }

        public static int Eliminar(int iId)//Editar datos como enteros
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, iId)
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
