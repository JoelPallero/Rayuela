using BusinessLayer;
using EntityLayer;
using System;
using System.Data;
using System.Globalization;
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
        string Hora;
        string Minutos;
        int Terapeuta;
        bool PacienteEncontrado;
        bool EmptyFields;
        int IdPaciente;
        DateTime FechaTurno;
        DateTime HoraInicio;
        DateTime HoraFin;

        #endregion

        #region Metodos generales

        private void ClearTerapeuta()
        {
            foreach (Control text in AltaTerpeuta.Controls)
            {
                if (text is TextBox)
                {
                    text.Text = string.Empty;
                }
            }
        }

        private void ClearPaciente()
        {
            foreach (Control text in GroupPaciente.Controls)
            {
                if (text is TextBox)
                {
                    text.Text = string.Empty;
                }
            }
        }

        private void CheckEmptyTextBox()
        {
            foreach (Control text in GroupPaciente.Controls)
            {
                if (text is TextBox)
                {
                    if (string.IsNullOrEmpty(text.Text))
                    {
                        MessageBox.Show("No puede haber campos vacíos", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmptyFields = true;
                    }
                    else
                    {
                        EmptyFields = false;
                    }
                }
            }
        }

        private void SaveTerapeuta()
        {
            _terapeuta.NombreApellido = TxtNomreTerapeuta.Text;
            _terapeuta.Contraseña = TxtClaveTerapeuta.Text;
            _terapeuta.Terapia = TxtTerapiaTerapeuta.Text;
            _busTerapeuta.NuevoTerapeuta(_terapeuta);
        }

        private void SavePaciente()
        {
            if (PacienteEncontrado == false)
            {
                _paciente.Apellido = TxtApellidoPaciente.Text;
                _paciente.Nombre = TxtNombrePaciente.Text;
                _paciente.ObraSocial = TxtObraSocialPaciente.Text;
                _paciente.Terapia = TxtTerapiaPaciente.Text;
                _paciente.Dni = Convert.ToInt32(TxtNroDocumentoPaciente.Text);
                _paciente.CertificadoDiscapacidad = TxtCertificadoDiscapacidad.Text;
                _paciente.NroAfiliado = Convert.ToInt32(TxtNroAfiliado.Text);

                _busPaciente.SavePaciente(_paciente);
            }
        }

        private void GuardarTurno()
        {            
            _turno.Dia = FechaTurno;
            _turno.HoraInicio = HoraInicio;
            _turno.HoraFin = HoraFin;
            _turno.TerapeutaId = CmbTerapeuta.SelectedIndex + 1;
            _turno.PacienteId = IdPaciente;
            _busTurno.CargarTurno(_turno);
        }

        public void ConsultarIdPaciente()
        {
            if (PacienteEncontrado == false)
            {
                _paciente = _busPaciente.ConsutlarIdPaciente(_paciente);
                IdPaciente = _paciente.Id;
            }
        }

        private void CargarTerapeuta()
        {
            DataTable dt = _busTerapeuta.TraerTerapeutas();
            CmbTerapeuta.DataSource = dt;
            CmbTerapeuta.DisplayMember = "NombreApellido";
        }

        private void CargarPaciente()
        {
            _paciente.Dni = Convert.ToInt32(TxtNroDocumentoPaciente.Text);
            _busPaciente.BuscarPaciente(_paciente);
            if (_paciente.Dni != 0)
            {
                IdPaciente = _paciente.Id;
                TxtApellidoPaciente.Text = _paciente.Apellido.ToString();
                TxtNombrePaciente.Text = _paciente.Nombre.ToString();
                TxtNroDocumentoPaciente.Text = _paciente.Dni.ToString();
                TxtCertificadoDiscapacidad.Text = _paciente.CertificadoDiscapacidad.ToString();
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

        private void AsignarHorarios()
        {
            Hora = CmbHora.Text;
            Minutos = CmbMinutos.Text;
            string FechaActual = Fecha + " " + Hora + ":" + Minutos + ":00";

            string HoraInicial = FechaActual;

            DateTime.TryParse(FechaActual, out FechaTurno);
            DateTime.TryParse(HoraInicial, out HoraInicio);

            string HoraFinal = Convert.ToString(FechaTurno.AddMinutes(45));
            DateTime.TryParse(HoraFinal, out HoraFin);
        }
        #endregion

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            AsignarHorarios();
            SavePaciente();
            ConsultarIdPaciente();
            GuardarTurno();
            Notificacion();
            ClearTerapeuta();
        }

        private void TxtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // traer los datos de un paciente que tenga el N° de documento en este textbox
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtNroDocumentoPaciente.Text != string.Empty)
                {
                    CargarPaciente();
                }
            }
        }

        private void BtnCargarTerapeuta_Click(object sender, EventArgs e)
        {
            SaveTerapeuta();
            ClearTerapeuta();
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
            string FechaActual = DateTime.Now.ToShortDateString();
            Fecha = DtCalendario.Value.ToShortDateString();

            DateTime FA = Convert.ToDateTime(FechaActual);
            DateTime Fa2 = Convert.ToDateTime(Fecha);

            if (Fa2 < FA)
            {
                DtCalendario.Value = FA;
                MessageBox.Show("No se puede seleccionar una fecha anterior a la actual", "Inconsistencias", MessageBoxButtons.OK);
            }
            else
            {
                CargarTerapeuta();
                AsignarFecha();
                Terapeuta = CmbTerapeuta.SelectedIndex + 1;
                //CargarhorariosDesocupados();
            }
        }

        private void AsignarFecha()
        {
            Fecha = Convert.ToString(DtCalendario.Value.Day + "/"
                                   + DtCalendario.Value.Month + "/"
                                   + DtCalendario.Value.Year);
            Terapeuta = CmbTerapeuta.SelectedIndex + 1;
        }

        private void TxtNroDocumento_Leave(object sender, EventArgs e)
        {
            if (TxtNroDocumentoPaciente.Text != string.Empty)
            {
                CargarPaciente();
            }
        }

        private void Notificacion()
        {
            ConfirmacionDeTurno.Text = "Rayuela";
            ConfirmacionDeTurno.BalloonTipTitle = "Nuevo Turno Registrado";
            ConfirmacionDeTurno.BalloonTipText = "Se registro el turno para el paciente " +
                                    TxtApellidoPaciente.Text + " " + TxtNombrePaciente.Text +
                                    ", para el día: " + Convert.ToString(Fecha) + ", a la Hora: " + Hora + ":" + Minutos + ".";
            ConfirmacionDeTurno.BalloonTipIcon = ToolTipIcon.Info;
            ConfirmacionDeTurno.Visible = true;
            ConfirmacionDeTurno.ShowBalloonTip(6000);
        }
    }
}