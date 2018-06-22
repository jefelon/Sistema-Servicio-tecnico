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
       public class FDetalleCompra
    {
        public static DataSet GetAll(int compraId)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@CompraId",SqlDbType.Int,0,compraId),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FDetalleCompra_GetAll", dbParams);
        }

        public static int Insertar(DetalleCompra detallecompra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {//Id, CompraId, ProductoId, Cantidad, PrecioUnitario, ConversionId
                DBHelper.MakeParam("@CompraId",SqlDbType.Int,0,detallecompra.Compra.Id),
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,detallecompra.Producto.Id),
                DBHelper.MakeParam("@Cantidad",SqlDbType.Decimal,0,detallecompra.Cantidad),
                DBHelper.MakeParam("@PrecioUnitario",SqlDbType.Decimal,0,detallecompra.PrecioUnitario)
                //DBHelper.MakeParam("@ConversionId",SqlDbType.Int,0,detallecompra.Conversion.Id),
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleCompra_Insertar", dbParams));
        }
        public static int Actualizar(DetalleCompra detallecompra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,detallecompra.Id),
                DBHelper.MakeParam("@CompraId",SqlDbType.Int,0,detallecompra.Compra.Id),
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,detallecompra.Producto.Id),
                DBHelper.MakeParam("@Cantidad",SqlDbType.Decimal,0,detallecompra.Cantidad),
                DBHelper.MakeParam("@PrecioUnitario",SqlDbType.Decimal,0,detallecompra.PrecioUnitario)
                //DBHelper.MakeParam("@ConversionId",SqlDbType.Int,0,detallecompra.Conversion.Id),
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleCompra_Actualizar", dbParams));
        }
        public static int Eliminar(DetalleCompra detallecompra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,detallecompra.Id),
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleCompra_Eliminar", dbParams));
        }
        
    }
}
