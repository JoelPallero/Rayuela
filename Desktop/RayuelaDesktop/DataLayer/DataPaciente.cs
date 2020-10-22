﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataPaciente : DataAccess
    {
        public int SavePaciente(Paciente _paciente)
        {
            int resultado = -1;
            string query = @"Insert into Pacientes (Nombre,
                                                    Apellido,
                                                    TipoDocumento,
                                                    NroDocumento,
                                                    ObraSocial,
                                                    NroAfiliado,
                                                    CertificadoDiscapacidad,
                                                    NroCarnetDiscapacidad,
                                                    Terapia) 
                                             values(@Nombre,
                                                    @Apellido,
                                                    @TipoDocumento,
                                                    @NroDocumento,
                                                    @ObraSocial,
                                                    @NroAfiliado,
                                                    @CertificadoDiscapacidad,
                                                    @NroCarnetDiscapacidad,
                                                    @Terapia)"
            ;

            SqlParameter nombre = new SqlParameter("@Nombre", _paciente.Nombre);
            SqlParameter apellido = new SqlParameter("@Apellido", _paciente.Apellido);
            SqlParameter tipoDocumento = new SqlParameter("@TipoDocumento", _paciente.TipoDocumento);
            SqlParameter nroDocumento = new SqlParameter("@NroDocumento", _paciente.NroDocumento);
            SqlParameter obraSocial = new SqlParameter("@ObraSocial", _paciente.ObraSocial);
            SqlParameter nroAfiliado = new SqlParameter("@NroAfiliado", _paciente.NroAfiliado);
            SqlParameter certificadoDiscapacidad = new SqlParameter("@CertificadoDiscapacidad", _paciente.CertificadoDiscapacidad);
            SqlParameter nroCarnetDiscapacidad = new SqlParameter("@NroCarnetDiscapacidad", _paciente.NroCarnetDiscapacidad);
            SqlParameter terapia = new SqlParameter("@Terapia", _paciente.Terapia);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(apellido);
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
    }
}