using EntityLayer;
using System;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataPaciente : DataAccess
    {
        public int NuevoPaciente(Paciente _paciente)
        {
            int resultado = -1;
            string query = @"Insert into Pacientes (Nombre,
                                                    Apellido,
                                                    ObraSocial,
                                                    Terapia,
                                                    DNI,
                                                    CertificadoDiscapacidad,
                                                    NroAfiliado,
                                                    IdTerapeuta) 
                                             values(@Nombre,
                                                    @Apellido,
                                                    @ObraSocial,
                                                    @Terapia,
                                                    @DNI,
                                                    @CertificadoDiscapacidad,
                                                    @NroAfiliado,
                                                    @IdTerapeuta)"
            ;

            SqlParameter nombre = new SqlParameter("@Nombre", _paciente.Nombre);
            SqlParameter apellido = new SqlParameter("@Apellido", _paciente.Apellido);
            SqlParameter obraSocial = new SqlParameter("@ObraSocial", _paciente.ObraSocial);
            SqlParameter terapia = new SqlParameter("@Terapia", _paciente.Terapia);
            SqlParameter dNI = new SqlParameter("@DNI", _paciente.Dni);
            SqlParameter certificadoDiscapacidad = new SqlParameter("@CertificadoDiscapacidad", _paciente.CertificadoDiscapacidad);
            SqlParameter nroAfiliado = new SqlParameter("@NroAfiliado", _paciente.NroAfiliado);
            SqlParameter idTerapeuta = new SqlParameter("@IdTerapeuta", _paciente.IdTerapeuta);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(obraSocial);
            cmd.Parameters.Add(terapia);
            cmd.Parameters.Add(dNI);
            cmd.Parameters.Add(certificadoDiscapacidad);
            cmd.Parameters.Add(nroAfiliado);
            cmd.Parameters.Add(idTerapeuta);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo guardar los datos del paciente", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }

        public Paciente ConsutlarIdPaciente(Paciente _paciente)
        {
            string query = "Select Id from Pacientes where Id = (select max(Id) from Pacientes)";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    _paciente.Id = int.Parse(reader["Id"].ToString());
                }
                else
                {
                    _paciente.Id = 0;
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo consultar el Id", e);
            }
            finally
            {
                Cerrarconexion();
            }

            return _paciente;
        }

        public Paciente BuscarPaciente(Paciente _paciente)
        {
            string query = @"select *
                        from Pacientes
                        where DNI = '" + _paciente.Dni + "';"
            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _paciente.Id = int.Parse(reader["Id"].ToString());
                    _paciente.Apellido = reader["Apellido"].ToString();
                    _paciente.Nombre = reader["Nombre"].ToString();
                    _paciente.ObraSocial = reader["ObraSocial"].ToString();
                    _paciente.Terapia = reader["Terapia"].ToString();
                    _paciente.Dni = int.Parse(reader["DNI"].ToString());
                    _paciente.CertificadoDiscapacidad = reader["CertificadoDiscapacidad"].ToString();
                    _paciente.NroAfiliado = int.Parse(reader["NroAfiliado"].ToString());

                }
                else
                {
                    _paciente.Dni = 0;
                }
                reader.Close();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
            }

            return _paciente;
        }


    }
}
