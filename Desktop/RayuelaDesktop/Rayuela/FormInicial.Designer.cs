namespace Rayuela
{
    partial class FormInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabAgenda = new System.Windows.Forms.TabPage();
            this.GpTurnos = new System.Windows.Forms.GroupBox();
            this.LblHorarios = new System.Windows.Forms.Label();
            this.CmbHorarios = new System.Windows.Forms.ComboBox();
            this.BtnSchedule = new System.Windows.Forms.Button();
            this.AgendaDeTurnos = new System.Windows.Forms.MonthCalendar();
            this.CmbTerapeuta = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GpPaciente = new System.Windows.Forms.GroupBox();
            this.TxtCertificado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNombrePaciente = new System.Windows.Forms.TextBox();
            this.TxtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.CmbDiscapacidad = new System.Windows.Forms.ComboBox();
            this.TxtNroDocumento = new System.Windows.Forms.TextBox();
            this.TxtObraSocialPaciente = new System.Windows.Forms.TextBox();
            this.TxtNroAfiliado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTerapiaPaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TabABM = new System.Windows.Forms.TabPage();
            this.AsignaciónDeDias = new System.Windows.Forms.GroupBox();
            this.AltaTerpeuta = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtTerapiaTerapeuta = new System.Windows.Forms.TextBox();
            this.TxtNomreTerapeuta = new System.Windows.Forms.TextBox();
            this.TxtApellidoTerapeuta = new System.Windows.Forms.TextBox();
            this.TxtNroDocumentoTerapeuta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbTipoDocumentoTerapeuta = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnCargarTerapeuta = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabAgenda.SuspendLayout();
            this.GpTurnos.SuspendLayout();
            this.GpPaciente.SuspendLayout();
            this.TabABM.SuspendLayout();
            this.AltaTerpeuta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabAgenda);
            this.tabControl1.Controls.Add(this.TabABM);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // TabAgenda
            // 
            this.TabAgenda.Controls.Add(this.GpTurnos);
            this.TabAgenda.Controls.Add(this.GpPaciente);
            this.TabAgenda.Location = new System.Drawing.Point(4, 22);
            this.TabAgenda.Name = "TabAgenda";
            this.TabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.TabAgenda.Size = new System.Drawing.Size(501, 498);
            this.TabAgenda.TabIndex = 0;
            this.TabAgenda.Text = "Agenda";
            this.TabAgenda.UseVisualStyleBackColor = true;
            // 
            // GpTurnos
            // 
            this.GpTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpTurnos.Controls.Add(this.LblHorarios);
            this.GpTurnos.Controls.Add(this.CmbHorarios);
            this.GpTurnos.Controls.Add(this.BtnSchedule);
            this.GpTurnos.Controls.Add(this.AgendaDeTurnos);
            this.GpTurnos.Controls.Add(this.CmbTerapeuta);
            this.GpTurnos.Controls.Add(this.label9);
            this.GpTurnos.Location = new System.Drawing.Point(15, 291);
            this.GpTurnos.Name = "GpTurnos";
            this.GpTurnos.Size = new System.Drawing.Size(478, 199);
            this.GpTurnos.TabIndex = 24;
            this.GpTurnos.TabStop = false;
            this.GpTurnos.Text = "Turnos";
            // 
            // LblHorarios
            // 
            this.LblHorarios.AutoSize = true;
            this.LblHorarios.Location = new System.Drawing.Point(254, 84);
            this.LblHorarios.Name = "LblHorarios";
            this.LblHorarios.Size = new System.Drawing.Size(49, 13);
            this.LblHorarios.TabIndex = 23;
            this.LblHorarios.Text = "Horarios:";
            // 
            // CmbHorarios
            // 
            this.CmbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHorarios.FormattingEnabled = true;
            this.CmbHorarios.Location = new System.Drawing.Point(251, 100);
            this.CmbHorarios.Name = "CmbHorarios";
            this.CmbHorarios.Size = new System.Drawing.Size(212, 21);
            this.CmbHorarios.TabIndex = 11;
            // 
            // BtnSchedule
            // 
            this.BtnSchedule.Location = new System.Drawing.Point(320, 145);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.Size = new System.Drawing.Size(112, 42);
            this.BtnSchedule.TabIndex = 12;
            this.BtnSchedule.Text = "Guardar Turno";
            this.BtnSchedule.UseVisualStyleBackColor = true;
            this.BtnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // AgendaDeTurnos
            // 
            this.AgendaDeTurnos.Location = new System.Drawing.Point(12, 25);
            this.AgendaDeTurnos.Name = "AgendaDeTurnos";
            this.AgendaDeTurnos.TabIndex = 9;
            this.AgendaDeTurnos.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.AgendaDeTurnos_DateSelected);
            // 
            // CmbTerapeuta
            // 
            this.CmbTerapeuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTerapeuta.FormattingEnabled = true;
            this.CmbTerapeuta.Location = new System.Drawing.Point(251, 42);
            this.CmbTerapeuta.Name = "CmbTerapeuta";
            this.CmbTerapeuta.Size = new System.Drawing.Size(212, 21);
            this.CmbTerapeuta.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Terapeuta:";
            // 
            // GpPaciente
            // 
            this.GpPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpPaciente.Controls.Add(this.TxtCertificado);
            this.GpPaciente.Controls.Add(this.label10);
            this.GpPaciente.Controls.Add(this.TxtNombrePaciente);
            this.GpPaciente.Controls.Add(this.TxtApellidoPaciente);
            this.GpPaciente.Controls.Add(this.CmbDiscapacidad);
            this.GpPaciente.Controls.Add(this.TxtNroDocumento);
            this.GpPaciente.Controls.Add(this.TxtObraSocialPaciente);
            this.GpPaciente.Controls.Add(this.TxtNroAfiliado);
            this.GpPaciente.Controls.Add(this.label8);
            this.GpPaciente.Controls.Add(this.TxtTerapiaPaciente);
            this.GpPaciente.Controls.Add(this.label7);
            this.GpPaciente.Controls.Add(this.label1);
            this.GpPaciente.Controls.Add(this.label6);
            this.GpPaciente.Controls.Add(this.label2);
            this.GpPaciente.Controls.Add(this.label5);
            this.GpPaciente.Controls.Add(this.label3);
            this.GpPaciente.Controls.Add(this.CmbTipoDocumento);
            this.GpPaciente.Controls.Add(this.label4);
            this.GpPaciente.Location = new System.Drawing.Point(15, 16);
            this.GpPaciente.Name = "GpPaciente";
            this.GpPaciente.Size = new System.Drawing.Size(478, 269);
            this.GpPaciente.TabIndex = 23;
            this.GpPaciente.TabStop = false;
            this.GpPaciente.Text = "Datos del Paciente";
            // 
            // TxtCertificado
            // 
            this.TxtCertificado.Location = new System.Drawing.Point(149, 134);
            this.TxtCertificado.Name = "TxtCertificado";
            this.TxtCertificado.Size = new System.Drawing.Size(279, 20);
            this.TxtCertificado.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "N° Carnet Disc:";
            // 
            // TxtNombrePaciente
            // 
            this.TxtNombrePaciente.Location = new System.Drawing.Point(149, 26);
            this.TxtNombrePaciente.Name = "TxtNombrePaciente";
            this.TxtNombrePaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtNombrePaciente.TabIndex = 0;
            // 
            // TxtApellidoPaciente
            // 
            this.TxtApellidoPaciente.Location = new System.Drawing.Point(149, 53);
            this.TxtApellidoPaciente.Name = "TxtApellidoPaciente";
            this.TxtApellidoPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtApellidoPaciente.TabIndex = 1;
            // 
            // CmbDiscapacidad
            // 
            this.CmbDiscapacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDiscapacidad.FormattingEnabled = true;
            this.CmbDiscapacidad.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CmbDiscapacidad.Location = new System.Drawing.Point(215, 107);
            this.CmbDiscapacidad.Name = "CmbDiscapacidad";
            this.CmbDiscapacidad.Size = new System.Drawing.Size(60, 21);
            this.CmbDiscapacidad.TabIndex = 4;
            // 
            // TxtNroDocumento
            // 
            this.TxtNroDocumento.Location = new System.Drawing.Point(304, 81);
            this.TxtNroDocumento.Name = "TxtNroDocumento";
            this.TxtNroDocumento.Size = new System.Drawing.Size(124, 20);
            this.TxtNroDocumento.TabIndex = 3;
            this.TxtNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroDocumento_KeyPress);
            // 
            // TxtObraSocialPaciente
            // 
            this.TxtObraSocialPaciente.Location = new System.Drawing.Point(149, 160);
            this.TxtObraSocialPaciente.Name = "TxtObraSocialPaciente";
            this.TxtObraSocialPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtObraSocialPaciente.TabIndex = 6;
            // 
            // TxtNroAfiliado
            // 
            this.TxtNroAfiliado.Location = new System.Drawing.Point(149, 189);
            this.TxtNroAfiliado.Name = "TxtNroAfiliado";
            this.TxtNroAfiliado.Size = new System.Drawing.Size(279, 20);
            this.TxtNroAfiliado.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Terapia:";
            // 
            // TxtTerapiaPaciente
            // 
            this.TxtTerapiaPaciente.Location = new System.Drawing.Point(149, 218);
            this.TxtTerapiaPaciente.Name = "TxtTerapiaPaciente";
            this.TxtTerapiaPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtTerapiaPaciente.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Certificado de Discapacidad:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "N° de afiliado:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Obra social:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de documento:";
            // 
            // CmbTipoDocumento
            // 
            this.CmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDocumento.FormattingEnabled = true;
            this.CmbTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "DEA",
            "LE",
            "LC"});
            this.CmbTipoDocumento.Location = new System.Drawing.Point(149, 80);
            this.CmbTipoDocumento.Name = "CmbTipoDocumento";
            this.CmbTipoDocumento.Size = new System.Drawing.Size(120, 21);
            this.CmbTipoDocumento.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nro:";
            // 
            // TabABM
            // 
            this.TabABM.Controls.Add(this.AsignaciónDeDias);
            this.TabABM.Controls.Add(this.AltaTerpeuta);
            this.TabABM.Location = new System.Drawing.Point(4, 22);
            this.TabABM.Name = "TabABM";
            this.TabABM.Padding = new System.Windows.Forms.Padding(3);
            this.TabABM.Size = new System.Drawing.Size(501, 498);
            this.TabABM.TabIndex = 1;
            this.TabABM.Text = "ABM Terapeuta";
            this.TabABM.UseVisualStyleBackColor = true;
            // 
            // AsignaciónDeDias
            // 
            this.AsignaciónDeDias.Location = new System.Drawing.Point(8, 215);
            this.AsignaciónDeDias.Name = "AsignaciónDeDias";
            this.AsignaciónDeDias.Size = new System.Drawing.Size(457, 275);
            this.AsignaciónDeDias.TabIndex = 1;
            this.AsignaciónDeDias.TabStop = false;
            this.AsignaciónDeDias.Text = "Asignación de días";
            // 
            // AltaTerpeuta
            // 
            this.AltaTerpeuta.Controls.Add(this.label15);
            this.AltaTerpeuta.Controls.Add(this.TxtTerapiaTerapeuta);
            this.AltaTerpeuta.Controls.Add(this.TxtNomreTerapeuta);
            this.AltaTerpeuta.Controls.Add(this.TxtApellidoTerapeuta);
            this.AltaTerpeuta.Controls.Add(this.TxtNroDocumentoTerapeuta);
            this.AltaTerpeuta.Controls.Add(this.label11);
            this.AltaTerpeuta.Controls.Add(this.label12);
            this.AltaTerpeuta.Controls.Add(this.label13);
            this.AltaTerpeuta.Controls.Add(this.CmbTipoDocumentoTerapeuta);
            this.AltaTerpeuta.Controls.Add(this.label14);
            this.AltaTerpeuta.Controls.Add(this.BtnCargarTerapeuta);
            this.AltaTerpeuta.Location = new System.Drawing.Point(8, 16);
            this.AltaTerpeuta.Name = "AltaTerpeuta";
            this.AltaTerpeuta.Size = new System.Drawing.Size(457, 193);
            this.AltaTerpeuta.TabIndex = 0;
            this.AltaTerpeuta.TabStop = false;
            this.AltaTerpeuta.Text = "Alta de Terapeuta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Terapia:";
            // 
            // TxtTerapiaTerapeuta
            // 
            this.TxtTerapiaTerapeuta.Location = new System.Drawing.Point(143, 109);
            this.TxtTerapiaTerapeuta.Name = "TxtTerapiaTerapeuta";
            this.TxtTerapiaTerapeuta.Size = new System.Drawing.Size(279, 20);
            this.TxtTerapiaTerapeuta.TabIndex = 4;
            // 
            // TxtNomreTerapeuta
            // 
            this.TxtNomreTerapeuta.Location = new System.Drawing.Point(143, 28);
            this.TxtNomreTerapeuta.Name = "TxtNomreTerapeuta";
            this.TxtNomreTerapeuta.Size = new System.Drawing.Size(279, 20);
            this.TxtNomreTerapeuta.TabIndex = 0;
            // 
            // TxtApellidoTerapeuta
            // 
            this.TxtApellidoTerapeuta.Location = new System.Drawing.Point(143, 55);
            this.TxtApellidoTerapeuta.Name = "TxtApellidoTerapeuta";
            this.TxtApellidoTerapeuta.Size = new System.Drawing.Size(279, 20);
            this.TxtApellidoTerapeuta.TabIndex = 1;
            // 
            // TxtNroDocumentoTerapeuta
            // 
            this.TxtNroDocumentoTerapeuta.Location = new System.Drawing.Point(298, 83);
            this.TxtNroDocumentoTerapeuta.Name = "TxtNroDocumentoTerapeuta";
            this.TxtNroDocumentoTerapeuta.Size = new System.Drawing.Size(124, 20);
            this.TxtNroDocumentoTerapeuta.TabIndex = 3;
            this.TxtNroDocumentoTerapeuta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroDocumentoTerapeuta_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Apellido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Tipo de documento:";
            // 
            // CmbTipoDocumentoTerapeuta
            // 
            this.CmbTipoDocumentoTerapeuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDocumentoTerapeuta.FormattingEnabled = true;
            this.CmbTipoDocumentoTerapeuta.Items.AddRange(new object[] {
            "DNI",
            "DEA",
            "LE",
            "LC"});
            this.CmbTipoDocumentoTerapeuta.Location = new System.Drawing.Point(143, 82);
            this.CmbTipoDocumentoTerapeuta.Name = "CmbTipoDocumentoTerapeuta";
            this.CmbTipoDocumentoTerapeuta.Size = new System.Drawing.Size(120, 21);
            this.CmbTipoDocumentoTerapeuta.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Nro:";
            // 
            // BtnCargarTerapeuta
            // 
            this.BtnCargarTerapeuta.Location = new System.Drawing.Point(326, 144);
            this.BtnCargarTerapeuta.Name = "BtnCargarTerapeuta";
            this.BtnCargarTerapeuta.Size = new System.Drawing.Size(96, 36);
            this.BtnCargarTerapeuta.TabIndex = 5;
            this.BtnCargarTerapeuta.Text = "Cargar";
            this.BtnCargarTerapeuta.UseVisualStyleBackColor = true;
            this.BtnCargarTerapeuta.Click += new System.EventHandler(this.BtnCargarTerapeuta_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 524);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.tabControl1.ResumeLayout(false);
            this.TabAgenda.ResumeLayout(false);
            this.GpTurnos.ResumeLayout(false);
            this.GpTurnos.PerformLayout();
            this.GpPaciente.ResumeLayout(false);
            this.GpPaciente.PerformLayout();
            this.TabABM.ResumeLayout(false);
            this.AltaTerpeuta.ResumeLayout(false);
            this.AltaTerpeuta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabAgenda;
        private System.Windows.Forms.TabPage TabABM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTerapiaPaciente;
        private System.Windows.Forms.TextBox TxtNroAfiliado;
        private System.Windows.Forms.TextBox TxtObraSocialPaciente;
        private System.Windows.Forms.TextBox TxtNroDocumento;
        private System.Windows.Forms.TextBox TxtApellidoPaciente;
        private System.Windows.Forms.TextBox TxtNombrePaciente;
        private System.Windows.Forms.MonthCalendar AgendaDeTurnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbTerapeuta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbDiscapacidad;
        private System.Windows.Forms.GroupBox GpTurnos;
        private System.Windows.Forms.GroupBox GpPaciente;
        private System.Windows.Forms.Button BtnSchedule;
        private System.Windows.Forms.TextBox TxtCertificado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblHorarios;
        private System.Windows.Forms.ComboBox CmbHorarios;
        private System.Windows.Forms.GroupBox AsignaciónDeDias;
        private System.Windows.Forms.GroupBox AltaTerpeuta;
        private System.Windows.Forms.Button BtnCargarTerapeuta;
        private System.Windows.Forms.TextBox TxtNomreTerapeuta;
        private System.Windows.Forms.TextBox TxtApellidoTerapeuta;
        private System.Windows.Forms.TextBox TxtNroDocumentoTerapeuta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbTipoDocumentoTerapeuta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtTerapiaTerapeuta;
    }
}