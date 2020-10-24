using EntityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataTurno : DataAccess
    {
        public int CargarTurno(Turno turno)
        {
            int resultado = -1;

            try
            {
                Abrirconexion();

                string query = @"insert into Calendario (Dia, 
                                                    HoraInicio, 
                                                    HoraFin,
                                                    PacienteId,
                                                    TerapeutaId) 
                            values (@Dia, 
                                    @HoraInicio, 
                                    @HoraFin,
                                    @PacienteId,
                                    @TerapeutaId)"
                ;

                SqlParameter dia = new SqlParameter("@Dia", turno.Dia);
                SqlParameter horaInicio = new SqlParameter("@HoraInicio", turno.HoraInicio);
                SqlParameter horaFin = new SqlParameter("@HoraFin", turno.HoraFin);
                SqlParameter pacienteId = new SqlParameter("@PacienteId", turno.PacienteId);
                SqlParameter terapeutaId = new SqlParameter("@TerapeutaId", turno.TerapeutaId);

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.Add(dia);
                cmd.Parameters.Add(horaInicio);
                cmd.Parameters.Add(horaFin);
                cmd.Parameters.Add(pacienteId);
                cmd.Parameters.Add(terapeutaId);

                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
            }

            return resultado;
        }

        public DataTable TraerHorariosDesocupados(string Fecha)
        {
            string query = "Select h.HoraInicio from Horarios h " +
                           "where h.Id not in (Select HoraInicio from Calendario " +
                           "where Dia = '" + Fecha + "')";

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