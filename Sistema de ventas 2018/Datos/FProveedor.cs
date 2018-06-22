using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_ventas_2018.Negocio;

namespace Sistema_de_ventas_2018.Datos
{
    public class FProveedor
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FProveedor_GetAll", dbParams);
        }
        //Id, Nombre, Ruc, Direccion, Telefono, Email, FechaRegistro
        public static int Insertar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,proveedor.Nombre),
                DBHelper.MakeParam("@Ruc",SqlDbType.VarChar,0,proveedor.Ruc),
                DBHelper.MakeParam("@Direccion",SqlDbType.VarChar,0,proveedor.Direccion),
                DBHelper.MakeParam("@Telefono",SqlDbType.VarChar,0,proveedor.Telefono),
                DBHelper.MakeParam("@Email",SqlDbType.VarChar,0,proveedor.Email),
                DBHelper.MakeParam("@FechaRegistro",SqlDbType.DateTime,0,proveedor.FechaRegistro)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FProveedor_Insertar", dbParams));
        }
        public static int Actualizar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int, 0, proveedor.Id),
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar, 0, proveedor.Nombre),
                DBHelper.MakeParam("@Ruc",SqlDbType.VarChar, 0, proveedor.Ruc),
                DBHelper.MakeParam("@Direccion",SqlDbType.VarChar, 0, proveedor.Direccion),
                DBHelper.MakeParam("@Telefono",SqlDbType.VarChar, 0, proveedor.Telefono),
                DBHelper.MakeParam("@Email",SqlDbType.VarChar, 0, proveedor.Email),
                DBHelper.MakeParam("@FechaRegistro",SqlDbType.DateTime, 0, proveedor.FechaRegistro)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FProveedor_Actualizar", dbParams));
        }
        public static int Eliminar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,proveedor.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FProveedor_Eliminar", dbParams));
        }
    }

   }
