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
            string query = @"Insert into Pacientes (NombreApellido,
                                                    TipoDocumento,
                                                    NroDocumento,
                                                    ObraSocial,
                                                    NroAfiliado,
                                                    CertificadoDiscapacidad,
                                                    NroCarnetDiscapacidad,
                                                    Terapia) 
                                             values(@NombreApellido,
                                                    @TipoDocumento,
                                                    @NroDocumento,
                                                    @ObraSocial,
                                                    @NroAfiliado,
                                                    @CertificadoDiscapacidad,
                                                    @NroCarnetDiscapacidad,
                                                    @Terapia)"
            ;

            SqlParameter nombreApellido = new SqlParameter("@NombreApellido", _paciente.NombreApellido);
            SqlParameter tipoDocumento = new SqlParameter("@TipoDocumento", _paciente.TipoDocumento);
            SqlParameter nroDocumento = new SqlParameter("@NroDocumento", _paciente.NroDocumento);
            SqlParameter obraSocial = new SqlParameter("@ObraSocial", _paciente.ObraSocial);
            SqlParameter nroAfiliado = new SqlParameter("@NroAfiliado", _paciente.NroAfiliado);
            SqlParameter certificadoDiscapacidad = new SqlParameter("@CertificadoDiscapacidad", _paciente.CertificadoDiscapacidad);
            SqlParameter nroCarnetDiscapacidad = new SqlParameter("@NroCarnetDiscapacidad", _paciente.NroCarnetDiscapacidad);
            SqlParameter terapia = new SqlParameter("@Terapia", _paciente.Terapia);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(nombreApellido);
            cmd.Parameters.Add(tipoDocumento);
            cmd.Parameters.Add(nroDocumento);
            cmd.Parameters.Add(obraSocial);
            cmd.Parameters.Add(nroAfiliado);
            cmd.Parameters.Add(certificadoDiscapacidad);
            cmd.Parameters.Add(nroCarnetDiscapacidad);
            cmd.Parameters.Add(terapia);

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

        public Paciente BuscarPaciente(string dni, Paciente _paciente)
        {
            string query = @"select *
                        from Pacientes
                        where NroDocumento = '" + dni + "';"
            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _paciente.Id = int.Parse(reader["Id"].ToString());
                    _paciente.NombreApellido = reader["NombreApellido"].ToString();
                    _paciente.TipoDocumento = reader["TipoDocumento"].ToString();
                    _paciente.NroDocumento = reader["NroDocumento"].ToString();
                    _paciente.ObraSocial = reader["ObraSocial"].ToString();
                    _paciente.NroAfiliado = reader["NroAfiliado"].ToString();
                    _paciente.CertificadoDiscapacidad = reader["CertificadoDiscapacidad"].ToString();
                    _paciente.NroCarnetDiscapacidad = reader["NroCarnetDiscapacidad"].ToString();
                    _paciente.Terapia = reader["Terapia"].ToString();
                }
                else
                {
                    _paciente.NroDocumento = "0";
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
