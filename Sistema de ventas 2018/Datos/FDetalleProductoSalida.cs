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
       public class FDetalleProductoSalida
    {
        public static DataSet GetAll(int salidaId)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@SalidaId",SqlDbType.Int,0,salidaId)
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FDetalleProductoSalida_GetAll", dbParams);
        }
        public static int Insertar(DetalleProductoSalida detalleProductoSalida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,detalleProductoSalida.Producto.Id),
                DBHelper.MakeParam("@SalidaId",SqlDbType.Int,0,detalleProductoSalida.Salida.Id),
                DBHelper.MakeParam("@Precio",SqlDbType.Decimal,0,detalleProductoSalida.Precio),
                DBHelper.MakeParam("@Cantidad",SqlDbType.Decimal,0,detalleProductoSalida.Cantidad)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleProductoSalida_Insertar", dbParams));
        }
        public static int Actualizar(DetalleProductoSalida detalleProductoSalida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                //DBHelper.MakeParam("@Id",SqlDbType.Int,0,detalleproductosalida.Id),
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,detalleProductoSalida.Producto.Id),
                DBHelper.MakeParam("@SalidaId",SqlDbType.Int,0,detalleProductoSalida.Salida.Id),
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,detalleProductoSalida.Precio),
                DBHelper.MakeParam("@Cantidad",SqlDbType.Decimal,0,detalleProductoSalida.Cantidad)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleProdcutoSalida_Actualizar", dbParams));
        }
        public static int Eliminar(DetalleProductoSalida detalleProductoSalida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,detalleProductoSalida.Id)               
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleProdcutoSalida_Eliminar", dbParams));
        }
    }
}
