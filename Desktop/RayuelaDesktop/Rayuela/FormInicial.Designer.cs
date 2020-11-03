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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabAgenda = new System.Windows.Forms.TabPage();
            this.GpPaciente = new System.Windows.Forms.GroupBox();
            this.GroupPaciente = new System.Windows.Forms.GroupBox();
            this.TxtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCertificadoDiscapacidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.TxtNroDocumentoPaciente = new System.Windows.Forms.TextBox();
            this.TxtObraSocialPaciente = new System.Windows.Forms.TextBox();
            this.TxtNroAfiliado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTerapiaPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupAgenda = new System.Windows.Forms.GroupBox();
            this.CmbMinutos = new System.Windows.Forms.ComboBox();
            this.DtCalendario = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbTerapeuta = new System.Windows.Forms.ComboBox();
            this.LblHorarios = new System.Windows.Forms.Label();
            this.BtnSchedule = new System.Windows.Forms.Button();
            this.CmbHora = new System.Windows.Forms.ComboBox();
            this.TabABM = new System.Windows.Forms.TabPage();
            this.AsignaciónDeDias = new System.Windows.Forms.GroupBox();
            this.AltaTerpeuta = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtTerapiaTerapeuta = new System.Windows.Forms.TextBox();
            this.TxtNomreTerapeuta = new System.Windows.Forms.TextBox();
            this.TxtClaveTerapeuta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnCargarTerapeuta = new System.Windows.Forms.Button();
            this.NotiConfirmacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.TabAgenda.SuspendLayout();
            this.GpPaciente.SuspendLayout();
            this.GroupPaciente.SuspendLayout();
            this.GroupAgenda.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(508, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // TabAgenda
            // 
            this.TabAgenda.Controls.Add(this.GpPaciente);
            this.TabAgenda.Location = new System.Drawing.Point(4, 22);
            this.TabAgenda.Name = "TabAgenda";
            this.TabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.TabAgenda.Size = new System.Drawing.Size(500, 397);
            this.TabAgenda.TabIndex = 0;
            this.TabAgenda.Text = "Agenda";
            this.TabAgenda.UseVisualStyleBackColor = true;
            // 
            // GpPaciente
            // 
            this.GpPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpPaciente.Controls.Add(this.GroupPaciente);
            this.GpPaciente.Controls.Add(this.GroupAgenda);
            this.GpPaciente.Location = new System.Drawing.Point(10, 13);
            this.GpPaciente.Name = "GpPaciente";
            this.GpPaciente.Size = new System.Drawing.Size(484, 371);
            this.GpPaciente.TabIndex = 23;
            this.GpPaciente.TabStop = false;
            this.GpPaciente.Text = "Datos del Paciente";
            // 
            // GroupPaciente
            // 
            this.GroupPaciente.Controls.Add(this.TxtNombrePaciente);
            this.GroupPaciente.Controls.Add(this.label4);
            this.GroupPaciente.Controls.Add(this.TxtCertificadoDiscapacidad);
            this.GroupPaciente.Controls.Add(this.label10);
            this.GroupPaciente.Controls.Add(this.TxtApellidoPaciente);
            this.GroupPaciente.Controls.Add(this.TxtNroDocumentoPaciente);
            this.GroupPaciente.Controls.Add(this.TxtObraSocialPaciente);
            this.GroupPaciente.Controls.Add(this.TxtNroAfiliado);
            this.GroupPaciente.Controls.Add(this.label8);
            this.GroupPaciente.Controls.Add(this.TxtTerapiaPaciente);
            this.GroupPaciente.Controls.Add(this.label1);
            this.GroupPaciente.Controls.Add(this.label6);
            this.GroupPaciente.Controls.Add(this.label5);
            this.GroupPaciente.Controls.Add(this.label3);
            this.GroupPaciente.Location = new System.Drawing.Point(19, 19);
            this.GroupPaciente.Name = "GroupPaciente";
            this.GroupPaciente.Size = new System.Drawing.Size(441, 201);
            this.GroupPaciente.TabIndex = 25;
            this.GroupPaciente.TabStop = false;
            this.GroupPaciente.Text = "Datos del Paciente";
            // 
            // TxtNombrePaciente
            // 
            this.TxtNombrePaciente.Location = new System.Drawing.Point(136, 45);
            this.TxtNombrePaciente.Name = "TxtNombrePaciente";
            this.TxtNombrePaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtNombrePaciente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nombre:";
            // 
            // TxtCertificadoDiscapacidad
            // 
            this.TxtCertificadoDiscapacidad.Location = new System.Drawing.Point(136, 97);
            this.TxtCertificadoDiscapacidad.Name = "TxtCertificadoDiscapacidad";
            this.TxtCertificadoDiscapacidad.Size = new System.Drawing.Size(279, 20);
            this.TxtCertificadoDiscapacidad.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Cert. Discapacidad:";
            // 
            // TxtApellidoPaciente
            // 
            this.TxtApellidoPaciente.Location = new System.Drawing.Point(136, 19);
            this.TxtApellidoPaciente.Name = "TxtApellidoPaciente";
            this.TxtApellidoPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtApellidoPaciente.TabIndex = 0;
            // 
            // TxtNroDocumentoPaciente
            // 
            this.TxtNroDocumentoPaciente.Location = new System.Drawing.Point(136, 71);
            this.TxtNroDocumentoPaciente.Name = "TxtNroDocumentoPaciente";
            this.TxtNroDocumentoPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtNroDocumentoPaciente.TabIndex = 2;
            this.TxtNroDocumentoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroDocumento_KeyPress);
            // 
            // TxtObraSocialPaciente
            // 
            this.TxtObraSocialPaciente.Location = new System.Drawing.Point(136, 123);
            this.TxtObraSocialPaciente.Name = "TxtObraSocialPaciente";
            this.TxtObraSocialPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtObraSocialPaciente.TabIndex = 4;
            // 
            // TxtNroAfiliado
            // 
            this.TxtNroAfiliado.Location = new System.Drawing.Point(136, 149);
            this.TxtNroAfiliado.Name = "TxtNroAfiliado";
            this.TxtNroAfiliado.Size = new System.Drawing.Size(279, 20);
            this.TxtNroAfiliado.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Terapia:";
            // 
            // TxtTerapiaPaciente
            // 
            this.TxtTerapiaPaciente.Location = new System.Drawing.Point(136, 175);
            this.TxtTerapiaPaciente.Name = "TxtTerapiaPaciente";
            this.TxtTerapiaPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtTerapiaPaciente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "N° de afiliado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Obra social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "N° de documento:";
            // 
            // GroupAgenda
            // 
            this.GroupAgenda.Controls.Add(this.CmbMinutos);
            this.GroupAgenda.Controls.Add(this.DtCalendario);
            this.GroupAgenda.Controls.Add(this.label2);
            this.GroupAgenda.Controls.Add(this.label9);
            this.GroupAgenda.Controls.Add(this.CmbTerapeuta);
            this.GroupAgenda.Controls.Add(this.LblHorarios);
            this.GroupAgenda.Controls.Add(this.BtnSchedule);
            this.GroupAgenda.Controls.Add(this.CmbHora);
            this.GroupAgenda.Location = new System.Drawing.Point(19, 226);
            this.GroupAgenda.Name = "GroupAgenda";
            this.GroupAgenda.Size = new System.Drawing.Size(441, 139);
            this.GroupAgenda.TabIndex = 24;
            this.GroupAgenda.TabStop = false;
            this.GroupAgenda.Text = "Agenda de Turnos";
            // 
            // CmbMinutos
            // 
            this.CmbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMinutos.FormattingEnabled = true;
            this.CmbMinutos.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.CmbMinutos.Location = new System.Drawing.Point(355, 43);
            this.CmbMinutos.Name = "CmbMinutos";
            this.CmbMinutos.Size = new System.Drawing.Size(51, 21);
            this.CmbMinutos.TabIndex = 10;
            // 
            // DtCalendario
            // 
            this.DtCalendario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtCalendario.Location = new System.Drawing.Point(23, 45);
            this.DtCalendario.Name = "DtCalendario";
            this.DtCalendario.Size = new System.Drawing.Size(200, 20);
            this.DtCalendario.TabIndex = 7;
            this.DtCalendario.ValueChanged += new System.EventHandler(this.DtCalendario_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Seleccionar día:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Terapeuta:";
            // 
            // CmbTerapeuta
            // 
            this.CmbTerapeuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTerapeuta.FormattingEnabled = true;
            this.CmbTerapeuta.Location = new System.Drawing.Point(23, 101);
            this.CmbTerapeuta.Name = "CmbTerapeuta";
            this.CmbTerapeuta.Size = new System.Drawing.Size(212, 21);
            this.CmbTerapeuta.TabIndex = 8;
            // 
            // LblHorarios
            // 
            this.LblHorarios.AutoSize = true;
            this.LblHorarios.Location = new System.Drawing.Point(300, 26);
            this.LblHorarios.Name = "LblHorarios";
            this.LblHorarios.Size = new System.Drawing.Size(49, 13);
            this.LblHorarios.TabIndex = 37;
            this.LblHorarios.Text = "Horarios:";
            // 
            // BtnSchedule
            // 
            this.BtnSchedule.Location = new System.Drawing.Point(298, 78);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.Size = new System.Drawing.Size(112, 42);
            this.BtnSchedule.TabIndex = 11;
            this.BtnSchedule.Text = "Guardar Turno";
            this.BtnSchedule.UseVisualStyleBackColor = true;
            this.BtnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // CmbHora
            // 
            this.CmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHora.FormattingEnabled = true;
            this.CmbHora.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.CmbHora.Location = new System.Drawing.Point(298, 43);
            this.CmbHora.Name = "CmbHora";
            this.CmbHora.Size = new System.Drawing.Size(51, 21);
            this.CmbHora.TabIndex = 9;
            // 
            // TabABM
            // 
            this.TabABM.Controls.Add(this.AsignaciónDeDias);
            this.TabABM.Controls.Add(this.AltaTerpeuta);
            this.TabABM.Location = new System.Drawing.Point(4, 22);
            this.TabABM.Name = "TabABM";
            this.TabABM.Padding = new System.Windows.Forms.Padding(3);
            this.TabABM.Size = new System.Drawing.Size(500, 397);
            this.TabABM.TabIndex = 1;
            this.TabABM.Text = "ABM Terapeuta";
            this.TabABM.UseVisualStyleBackColor = true;
            // 
            // AsignaciónDeDias
            // 
            this.AsignaciónDeDias.Location = new System.Drawing.Point(8, 181);
            this.AsignaciónDeDias.Name = "AsignaciónDeDias";
            this.AsignaciónDeDias.Size = new System.Drawing.Size(485, 211);
            this.AsignaciónDeDias.TabIndex = 1;
            this.AsignaciónDeDias.TabStop = false;
            this.AsignaciónDeDias.Text = "Asignación de días";
            // 
            // AltaTerpeuta
            // 
            this.AltaTerpeuta.Controls.Add(this.label15);
            this.AltaTerpeuta.Controls.Add(this.TxtTerapiaTerapeuta);
            this.AltaTerpeuta.Controls.Add(this.TxtNomreTerapeuta);
            this.AltaTerpeuta.Controls.Add(this.TxtClaveTerapeuta);
            this.AltaTerpeuta.Controls.Add(this.label11);
            this.AltaTerpeuta.Controls.Add(this.label13);
            this.AltaTerpeuta.Controls.Add(this.BtnCargarTerapeuta);
            this.AltaTerpeuta.Location = new System.Drawing.Point(8, 16);
            this.AltaTerpeuta.Name = "AltaTerpeuta";
            this.AltaTerpeuta.Size = new System.Drawing.Size(485, 159);
            this.AltaTerpeuta.TabIndex = 0;
            this.AltaTerpeuta.TabStop = false;
            this.AltaTerpeuta.Text = "Alta de Terapeuta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Terapia:";
            // 
            // TxtTerapiaTerapeuta
            // 
            this.TxtTerapiaTerapeuta.Location = new System.Drawing.Point(143, 80);
            this.TxtTerapiaTerapeuta.Name = "TxtTerapiaTerapeuta";
            this.TxtTerapiaTerapeuta.Size = new System.Drawing.Size(279, 20);
            this.TxtTerapiaTerapeuta.TabIndex = 2;
            // 
            // TxtNomreTerapeuta
            // 
            this.TxtNomreTerapeuta.Location = new System.Drawing.Point(143, 28);
            this.TxtNomreTerapeuta.Name = "TxtNomreTerapeuta";
            this.TxtNomreTerapeuta.Size = new System.Drawing.Size(279, 20);
            this.TxtNomreTerapeuta.TabIndex = 0;
            // 
            // TxtClaveTerapeuta
            // 
            this.TxtClaveTerapeuta.Location = new System.Drawing.Point(143, 54);
            this.TxtClaveTerapeuta.Name = "TxtClaveTerapeuta";
            this.TxtClaveTerapeuta.Size = new System.Drawing.Size(279, 20);
            this.TxtClaveTerapeuta.TabIndex = 1;
            this.TxtClaveTerapeuta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroDocumentoTerapeuta_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nombre y Apellido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Contraseña:";
            // 
            // BtnCargarTerapeuta
            // 
            this.BtnCargarTerapeuta.Location = new System.Drawing.Point(326, 111);
            this.BtnCargarTerapeuta.Name = "BtnCargarTerapeuta";
            this.BtnCargarTerapeuta.Size = new System.Drawing.Size(96, 36);
            this.BtnCargarTerapeuta.TabIndex = 3;
            this.BtnCargarTerapeuta.Text = "Cargar";
            this.BtnCargarTerapeuta.UseVisualStyleBackColor = true;
            this.BtnCargarTerapeuta.Click += new System.EventHandler(this.BtnCargarTerapeuta_Click);
            // 
            // NotiConfirmacion
            // 
            this.NotiConfirmacion.Text = "Confirmarcion de Turno agendado";
            this.NotiConfirmacion.Visible = true;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 423);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(524, 462);
            this.MinimumSize = new System.Drawing.Size(524, 462);
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Turnos";
            this.tabControl1.ResumeLayout(false);
            this.TabAgenda.ResumeLayout(false);
            this.GpPaciente.ResumeLayout(false);
            this.GroupPaciente.ResumeLayout(false);
            this.GroupPaciente.PerformLayout();
            this.GroupAgenda.ResumeLayout(false);
            this.GroupAgenda.PerformLayout();
            this.TabABM.ResumeLayout(false);
            this.AltaTerpeuta.ResumeLayout(false);
            this.AltaTerpeuta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabAgenda;
        private System.Windows.Forms.TabPage TabABM;
        private System.Windows.Forms.GroupBox GpPaciente;
        private System.Windows.Forms.GroupBox AsignaciónDeDias;
        private System.Windows.Forms.GroupBox AltaTerpeuta;
        private System.Windows.Forms.Button BtnCargarTerapeuta;
        private System.Windows.Forms.TextBox TxtNomreTerapeuta;
        private System.Windows.Forms.TextBox TxtClaveTerapeuta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtTerapiaTerapeuta;
        private System.Windows.Forms.GroupBox GroupPaciente;
        private System.Windows.Forms.TextBox TxtCertificadoDiscapacidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtApellidoPaciente;
        private System.Windows.Forms.TextBox TxtNroDocumentoPaciente;
        private System.Windows.Forms.TextBox TxtObraSocialPaciente;
        private System.Windows.Forms.TextBox TxtNroAfiliado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTerapiaPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupAgenda;
        private System.Windows.Forms.ComboBox CmbMinutos;
        private System.Windows.Forms.DateTimePicker DtCalendario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbTerapeuta;
        private System.Windows.Forms.Label LblHorarios;
        private System.Windows.Forms.Button BtnSchedule;
        private System.Windows.Forms.ComboBox CmbHora;
        private System.Windows.Forms.TextBox TxtNombrePaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon NotiConfirmacion;
    }
}