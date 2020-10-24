using EntityLayer;
using System;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataHorarios : DataAccess
    {
        public Horarios SeleccionDeHorario(int Id, Horarios _horarios)
        {
            string query = "select Id from Horarios where Id = '" + Id + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _horarios.Id = int.Parse(reader["Id"].ToString());
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
            }

            return _horarios;
        }
    }
}
