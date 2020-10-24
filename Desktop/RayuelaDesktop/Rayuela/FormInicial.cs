using BusinessLayer;
using EntityLayer;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class FormInicial : Form
    {
        #region Instancia de clases
        private Turno _turno = new Turno();
        private Paciente _paciente = new Paciente();
        private Terapeuta _terapeuta = new Terapeuta();
        private Horarios _horarios = new Horarios();
        private BusTurno _busTurno = new BusTurno();
        private BusHorarios _busHorarios = new BusHorarios();
        private BusPaciente _busPaciente = new BusPaciente();
        private BusTerapeuta _busTerapeuta = new BusTerapeuta();
        #endregion

        public FormInicial()
        {
            InitializeComponent();

        }

        #region Variables

        string Fecha;
        bool PacienteEncontrado;
        int IdPaciente;

        #endregion

        #region Metodos generales

        private void ClearPage()
        {
            foreach (Control text in GpPaciente.Controls)
            {
                if (text is TextBox)
                {
                    text.Text = string.Empty;
                }
            }
        }

        private void CheckEmptyTextBox()
        {
            foreach (Control text in GpPaciente.Controls)
            {
                if (text is TextBox 
                    && string.IsNullOrEmpty(text.Text) 
                    || string.IsNullOrWhiteSpace(text.Text))
                {
                    MessageBox.Show("No puede haber campos vacíos", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SavePaciente()
        {
            if (PacienteEncontrado == false)
            {
                _paciente.NombreApellido = TxtNombrePaciente.Text;
                _paciente.TipoDocumento = CmbTipoDocumento.SelectedItem.ToString();
                _paciente.NroDocumento = TxtNroDocumento.Text;
                _paciente.ObraSocial = TxtObraSocialPaciente.Text;
                _paciente.NroAfiliado = TxtNroAfiliado.Text;
                _paciente.CertificadoDiscapacidad = CmbDiscapacidad.SelectedItem.ToString();

                if (CmbDiscapacidad.SelectedItem.ToString() == "Si")
                {
                    _paciente.NroCarnetDiscapacidad = TxtCertificado.Text;
                }
                else
                {
                    _paciente.NroCarnetDiscapacidad = "0";
                }
                _paciente.Terapia = TxtTerapiaPaciente.Text;

                _busPaciente.SavePaciente(_paciente);
            }
        }

        private void GuardarTurno()
        {
            _turno.Dia = Fecha;

            _turno.HoraInicio = CmbHorarios.SelectedIndex + 1;
            _turno.HoraFin = CmbHorarios.SelectedIndex + 1;

            _turno.TerapeutaId = CmbTerapeuta.SelectedIndex + 1;
            _turno.PacienteId = IdPaciente;
            _busTurno.CargarTurno(_turno);
        }

        public void ConsultarIdPaciente()
        {
            _paciente = _busPaciente.ConsutlarIdPaciente(_paciente);
            IdPaciente = _paciente.Id;
        }

        private void CargarhorariosDesocupados()
        {
            DataTable Dt1 = _busTurno.TraerHorariosDesocupados(Fecha);

            CmbHorarios.DataSource = Dt1;
            CmbHorarios.DisplayMember = "HoraInicio";
        }

        private void SaveTerapeuta()
        {
            _terapeuta.NombreApellido = TxtNomreTerapeuta.Text;
            _terapeuta.TipoDocumento = CmbTipoDocumentoTerapeuta.SelectedItem.ToString();
            _terapeuta.NroDocumento = TxtNroDocumentoTerapeuta.Text;
            _terapeuta.Terapia = TxtTerapiaTerapeuta.Text;
            _busTerapeuta.NuevoTerapeuta(_terapeuta);
        }

        private void CargarTerapeuta()
        {
            DataTable dt = _busTerapeuta.TraerTerapeutas();
            CmbTerapeuta.DataSource = dt;
            CmbTerapeuta.ValueMember = "NombreApellido";
        }

        private void CargarPaciente()
        {
            _busPaciente.BuscarPaciente(TxtNroDocumento.Text, _paciente);
            if (_paciente.NroDocumento != "0")
            {
                TxtNombrePaciente.Text = _paciente.NombreApellido.ToString();
                CmbTipoDocumento.Text = _paciente.TipoDocumento.ToString();
                TxtNroDocumento.Text = _paciente.NroDocumento.ToString();
                CmbDiscapacidad.Text = _paciente.CertificadoDiscapacidad.ToString();
                TxtCertificado.Text = _paciente.NroCarnetDiscapacidad.ToString();
                TxtObraSocialPaciente.Text = _paciente.ObraSocial.ToString();
                TxtNroAfiliado.Text = _paciente.NroAfiliado.ToString();
                TxtTerapiaPaciente.Text = _paciente.Terapia.ToString();
                PacienteEncontrado = true;
            }
            else
            {
                PacienteEncontrado = false;
            }
        }
        #endregion

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            SavePaciente();
            ConsultarIdPaciente();
            GuardarTurno();
            ClearPage();
        }        

        private void TxtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // traer los datos de un paciente que tenga el N° de documento en este textbox
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtNroDocumento.Text != string.Empty)
                {
                    CargarPaciente();
                }
            }
        }

        private void BtnCargarTerapeuta_Click(object sender, EventArgs e)
        {
            SaveTerapeuta();
            ClearPage();
        }       

        private void TxtNroDocumentoTerapeuta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarTerapeuta();
            }
        }

        private void DtCalendario_ValueChanged(object sender, EventArgs e)
        {
            CargarTerapeuta();
            Fecha = Convert.ToString(DtCalendario.Value.Day + "/"
                                   + DtCalendario.Value.Month + "/"
                                   + DtCalendario.Value.Year);
            CargarhorariosDesocupados();
        }

        private void TxtNroDocumento_Leave(object sender, EventArgs e)
        {
            if (TxtNroDocumento.Text != string.Empty)
            {
                CargarPaciente();
            }
        }        
    }
}