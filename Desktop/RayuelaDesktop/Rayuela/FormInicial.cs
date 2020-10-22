using BusinessLayer;
using EntityLayer;
using System;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class FormInicial : Form
    {
        #region Instancia de clases
        private Paciente _paciente = new Paciente();
        private BusPaciente _busPaciente = new BusPaciente();
        private MetodosDeConsulta _metodosDeConsulta = new MetodosDeConsulta();
        #endregion

        public FormInicial()
        {
            InitializeComponent();
            
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            SavePaciente();
            _metodosDeConsulta.ConsultarIdPaciente();
            if (_metodosDeConsulta.IdPaciente != 0)
            {
                _metodosDeConsulta.ConsultarIdTerapeuta(CmbTerapeuta.SelectedItem.ToString());
                if (_metodosDeConsulta.IdTerapeuta != 0)
                {
                    GuardarTurno();
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún paciente registrado", "Error en la carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePaciente()
        {
            _paciente.Nombre = TxtNombrePaciente.Text;
            _paciente.Apellido = TxtApellidoPaciente.Text;
            _paciente.TipoDocumento = CmbTipoDocumento.SelectedItem.ToString();
            _paciente.NroDocumento = Convert.ToInt32(TxtNroDocumento.Text);
            _paciente.ObraSocial = TxtObraSocialPaciente.Text;
            _paciente.NroAfiliado = Convert.ToInt32(TxtNroAfiliado.Text);
            _paciente.CertificadoDiscapacidad = CmbDiscapacidad.SelectedItem.ToString();
            if (CmbDiscapacidad.SelectedItem.ToString() == "Si")
            {
                _paciente.NroCarnetDiscapacidad = Convert.ToInt32(TxtCertificado.Text);
            }
            else
            {
                _paciente.NroCarnetDiscapacidad = 0;
            }
            _paciente.Terapia = TxtTerapiaPaciente.Text;

            _busPaciente.SavePaciente(_paciente);
        }

        private void GuardarTurno()
        {

        }

        private void AgendaDeTurnos_DateSelected(object sender, DateRangeEventArgs e)
        {
            //verificar el día seleccionado
            //consultar los terapeutas que trabajan ese dia
            //Consultar los terapeutas que atienden dependiendo de la terapia necesaria para el paciente
            //Consultar los horarios que no están agendados
            //mostrar los datos de los horarios y terapeutas disponibles
        }
    }
}
