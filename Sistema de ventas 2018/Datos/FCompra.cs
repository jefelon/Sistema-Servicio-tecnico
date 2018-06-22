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
        public class FCompra
    {
        public static DataSet GetVista()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FCompra_GetVista", dbParams);
        }

        public static DataSet GetBuscar(int BuscarRuc)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Ruc",SqlDbType.Int,0,BuscarRuc),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FCompra_GetBucar", dbParams);
        }

        public static DataSet Get(int id)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,id),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FCompra_Get", dbParams);
        }

        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FCompra_GetAll", dbParams);
        }
        public static int Insertar(Compra compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@ProveedorId",SqlDbType.Int,0,compra.Proveedor.Id),
                DBHelper.MakeParam("@UsuarioId",SqlDbType.Int,0,compra.Usuario),
                DBHelper.MakeParam("@TipoDocumentoId",SqlDbType.Int,0,compra.TipoDocumento.Id),
                DBHelper.MakeParam("@Nro_comprobante",SqlDbType.VarChar,0,compra.Nro_compronbante),
                DBHelper.MakeParam("@Fecha",SqlDbType.DateTime,0,compra.Fecha)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCompra_Insertar", dbParams));
        }
        public static int Actualizar(Compra compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,compra.Id),
                DBHelper.MakeParam("@ProveedorId",SqlDbType.Int,0,compra.Proveedor.Id),
                DBHelper.MakeParam("@UsuarioId",SqlDbType.Int,0,compra.Usuario),
                DBHelper.MakeParam("@TipoDocumentoId",SqlDbType.Int,0,compra.TipoDocumento.Id),
                DBHelper.MakeParam("@Nro_comprobante",SqlDbType.VarChar,0,compra.Nro_compronbante),
                DBHelper.MakeParam("@Fecha",SqlDbType.DateTime,0,compra.Fecha)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCompra_Actualizar", dbParams));
        }
        public static int Eliminar(Compra compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
           {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,compra.Id),
           };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCompra_Eliminar", dbParams));
       }
        public static DataSet Buscar(string nombre)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, nombre)
                };
            return DBHelper.ExecuteDataSet("usp_Datos_FProveedor_Buscar", dbParams);

        }

    }
}
