using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataTerapeuta : DataAccess
    {
        public int NuevoTerapeuta(Terapeuta _terapeuta)
        {
            int resultado = -1;

            string query = @"Insert into Terapeutas (Nombre, Apellido, TipoDocumento, NroDocumento, Terapia)
                            values (@Nombre, @Apellido, @TipoDocumento, @NroDocumento, @Terapia)"
            ;
            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlParameter nombre = new SqlParameter("@Nombre", _terapeuta.Nombre);
            SqlParameter apellido = new SqlParameter("@Apellido", _terapeuta.Apellido);
            SqlParameter tipoDocumento = new SqlParameter("@TipoDocumento", _terapeuta.TipoDocumento);
            SqlParameter nroDocumento = new SqlParameter("@NroDocumento", _terapeuta.NroDocumento);
            SqlParameter terapia = new SqlParameter("@Terapia", _terapeuta.Terapia);

            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(tipoDocumento);
            cmd.Parameters.Add(nroDocumento);
            cmd.Parameters.Add(terapia);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }

        public DataTable TraerTerapeutas()
        {
            string query = "SELECT Nombre, Apellido From Terapeutas";

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return dt;
        }
    }
}
