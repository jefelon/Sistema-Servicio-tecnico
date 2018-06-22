using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Datos
{
    public class FCliente
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FCliente_GetAll", dbParams);
        }
        public static int Insertar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Tipo_doc", SqlDbType.VarChar,0,cliente.Tipo_doc),
                DBHelper.MakeParam("@Ruc",SqlDbType.VarChar,0,cliente.Ruc),
                DBHelper.MakeParam("@Dni", SqlDbType.VarChar,0,cliente.Dni),
                DBHelper.MakeParam("@Numero_doc" ,SqlDbType.VarChar,0,cliente.Numero_doc),
                DBHelper.MakeParam("@Razon_social" ,SqlDbType.VarChar,0,cliente.Razon_social),
                DBHelper.MakeParam("@Nombre" ,SqlDbType.VarChar,0,cliente.Nombre),
                DBHelper.MakeParam("@ApellidoPaterno" ,SqlDbType.VarChar,0,cliente.ApellidoPaterno),
                DBHelper.MakeParam("@ApellidoMaterno" ,SqlDbType.VarChar,0,cliente.ApellidoMaterno),
                DBHelper.MakeParam("@Email" ,SqlDbType.VarChar,0,cliente.Email),
                DBHelper.MakeParam("@Telefono" ,SqlDbType.VarChar,0,cliente.Telefono),
                DBHelper.MakeParam("@Celular" ,SqlDbType.VarChar,0,cliente.Celular),
                DBHelper.MakeParam("@Direccion" ,SqlDbType.VarChar,0,cliente.Direccion),
                DBHelper.MakeParam("@FechaRegistro" ,SqlDbType.DateTime,0,cliente.FechaRegistro)
              };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCliente_Insertar", dbParams));
        }
        public static int Actualizar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,cliente.Id),
                DBHelper.MakeParam("@Tipo_doc", SqlDbType.VarChar,0,cliente.Tipo_doc),
                DBHelper.MakeParam("@Ruc",SqlDbType.VarChar,0,cliente.Ruc),
                DBHelper.MakeParam("@Dni", SqlDbType.VarChar,0,cliente.Dni),
                DBHelper.MakeParam("@Numero_doc" ,SqlDbType.VarChar,0,cliente.Numero_doc),
                DBHelper.MakeParam("@Razon_social" ,SqlDbType.VarChar,0,cliente.Razon_social),
                DBHelper.MakeParam("@Nombre" ,SqlDbType.VarChar,0,cliente.Nombre),
                DBHelper.MakeParam("@ApellidoPaterno" ,SqlDbType.VarChar,0,cliente.ApellidoPaterno),
                DBHelper.MakeParam("@ApellidoMaterno" ,SqlDbType.VarChar,0,cliente.ApellidoMaterno),
                DBHelper.MakeParam("@Email" ,SqlDbType.VarChar,0,cliente.Email),
                DBHelper.MakeParam("@Telefono" ,SqlDbType.VarChar,0,cliente.Telefono),
                DBHelper.MakeParam("@Celular" ,SqlDbType.VarChar,0,cliente.Celular),
                DBHelper.MakeParam("@Direccion" ,SqlDbType.VarChar,0,cliente.Direccion),
                DBHelper.MakeParam("@FechaRegistro" ,SqlDbType.DateTime,0,cliente.FechaRegistro)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCliente_Actualizar", dbParams));
        }
        public static int Eliminar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id" ,SqlDbType.Int,0,cliente.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCliente_Eliminar", dbParams));
        }
        public static DataSet Buscar(string nombre)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, nombre)
                };
            return DBHelper.ExecuteDataSet("usp_Datos_FCliente_Buscar", dbParams);

        }
    }
}
