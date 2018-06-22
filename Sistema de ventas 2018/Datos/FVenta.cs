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
    public class FVenta
    {
        public static DataSet GetVista()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FVenta_GetVista", dbParams);
        }
        public static DataSet GetBuscar(int BuscarDni)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Dni",SqlDbType.Int,0,BuscarDni),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FVenta_GetBuscar", dbParams);
        }


        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FVenta_GetAll", dbParams);
        }
        public static int Insertar(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@ClienteId",SqlDbType.Int,0,venta.Cliente.Id),
                DBHelper.MakeParam("@UsuarioId",SqlDbType.Int,0,venta.UsuarioId),
                DBHelper.MakeParam("@TipoDocumentoId",SqlDbType.Int,0,venta.TipoDocumento.Id),
                DBHelper.MakeParam("@fecha",SqlDbType.DateTime,0,venta.Fecha),
                DBHelper.MakeParam("@Serie",SqlDbType.Int,0,venta.Cliente.Id),
                DBHelper.MakeParam("@NumeroDocumento",SqlDbType.Int,0,venta.NumeroDocumento)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FVenta_Insertar", dbParams));
        }

        public static DataSet Get(int id)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,id),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FVenta_Get", dbParams);
        }

        public static int Actualizar(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,venta.Id),
                DBHelper.MakeParam("@ClienteId",SqlDbType.Int,0,venta.Cliente.Id),
                DBHelper.MakeParam("@UsuarioId",SqlDbType.Int,0,venta.UsuarioId),
                DBHelper.MakeParam("@TipoDocumentoId",SqlDbType.Int,0,venta.TipoDocumento),
                DBHelper.MakeParam("@fecha",SqlDbType.DateTime,0,venta.Fecha),
                 DBHelper.MakeParam("@Serie",SqlDbType.Int,0,venta.Cliente.Id),
                DBHelper.MakeParam("@NumeroDocumento",SqlDbType.Int,0,venta.NumeroDocumento)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FVenta_Actualizar", dbParams));
        }
        public static int Eliminar(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,venta.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FVenta_Eliminar",dbParams));
        }
        public static DataSet GenerarNumeroDocumento(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Serie",SqlDbType.Int,0,venta.Serie),
                DBHelper.MakeParam("@TipoDocumentoId",SqlDbType.Int,0,venta.TipoDocumento.Id)
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FVenta_GenerarNumeroDocumento", dbParams);
        }
        
    }
}
