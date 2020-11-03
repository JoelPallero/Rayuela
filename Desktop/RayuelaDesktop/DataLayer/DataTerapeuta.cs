using EntityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataTerapeuta : DataAccess
    {
        public int NuevoTerapeuta(Terapeuta _terapeuta)
        {
            int resultado = -1;

            string query = @"Insert into Terapeutas (NombreApellido, Contraseña, Terapia)
                            values (@NombreApellido, @Contraseña, @Terapia)"
            ;
            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlParameter nombreApellido = new SqlParameter("@NombreApellido", _terapeuta.NombreApellido);
            SqlParameter contraseña = new SqlParameter("@Contraseña", _terapeuta.Contraseña);
            SqlParameter terapia = new SqlParameter("@Terapia", _terapeuta.Terapia);

            cmd.Parameters.Add(nombreApellido);
            cmd.Parameters.Add(contraseña);
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
            string query = "SELECT NombreApellido From Terapeutas";

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