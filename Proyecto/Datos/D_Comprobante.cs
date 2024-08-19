using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    internal class D_Comprobante
    {
        public DataSet ObtenerDatosComprobante(int codComprobante)
        {
            DataSet dsComprobante = new DataSet();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                // Crear conexión
                SqlCon = Conexion.getInstancia().CrearConexion();

                // Crear comando para el procedimiento almacenado
                SqlCommand Comando = new SqlCommand("USP_GET_COMPROBANTE_DATA", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro
                Comando.Parameters.Add("@CodComprobante", SqlDbType.Int).Value = codComprobante;

                // Crear un adaptador para llenar el DataSet
                SqlDataAdapter da = new SqlDataAdapter(Comando);

                // Llenar el DataSet con los resultados
                da.Fill(dsComprobante, "Comprobante");

                return dsComprobante;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
