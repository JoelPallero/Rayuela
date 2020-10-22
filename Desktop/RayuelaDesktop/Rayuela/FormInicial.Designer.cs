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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmbHorarios = new System.Windows.Forms.ComboBox();
            this.LblHorarios = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabAgenda.SuspendLayout();
            this.GpTurnos.SuspendLayout();
            this.GpPaciente.SuspendLayout();
            this.TabABM.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(764, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // TabAgenda
            // 
            this.TabAgenda.Controls.Add(this.GpTurnos);
            this.TabAgenda.Controls.Add(this.GpPaciente);
            this.TabAgenda.Location = new System.Drawing.Point(4, 22);
            this.TabAgenda.Name = "TabAgenda";
            this.TabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.TabAgenda.Size = new System.Drawing.Size(756, 498);
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
            this.GpTurnos.Location = new System.Drawing.Point(15, 179);
            this.GpTurnos.Name = "GpTurnos";
            this.GpTurnos.Size = new System.Drawing.Size(725, 311);
            this.GpTurnos.TabIndex = 24;
            this.GpTurnos.TabStop = false;
            this.GpTurnos.Text = "Turnos";
            // 
            // BtnSchedule
            // 
            this.BtnSchedule.Location = new System.Drawing.Point(607, 263);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.Size = new System.Drawing.Size(112, 42);
            this.BtnSchedule.TabIndex = 21;
            this.BtnSchedule.Text = "Guardar Turno";
            this.BtnSchedule.UseVisualStyleBackColor = true;
            this.BtnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // AgendaDeTurnos
            // 
            this.AgendaDeTurnos.Location = new System.Drawing.Point(12, 51);
            this.AgendaDeTurnos.Name = "AgendaDeTurnos";
            this.AgendaDeTurnos.TabIndex = 1;
            this.AgendaDeTurnos.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.AgendaDeTurnos_DateSelected);
            // 
            // CmbTerapeuta
            // 
            this.CmbTerapeuta.FormattingEnabled = true;
            this.CmbTerapeuta.Location = new System.Drawing.Point(251, 51);
            this.CmbTerapeuta.Name = "CmbTerapeuta";
            this.CmbTerapeuta.Size = new System.Drawing.Size(181, 21);
            this.CmbTerapeuta.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 35);
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
            this.GpPaciente.Size = new System.Drawing.Size(725, 157);
            this.GpPaciente.TabIndex = 23;
            this.GpPaciente.TabStop = false;
            this.GpPaciente.Text = "Datos del Paciente";
            // 
            // TxtCertificado
            // 
            this.TxtCertificado.Location = new System.Drawing.Point(479, 84);
            this.TxtCertificado.Name = "TxtCertificado";
            this.TxtCertificado.Size = new System.Drawing.Size(213, 20);
            this.TxtCertificado.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "N° Carnet Disc:";
            // 
            // TxtNombrePaciente
            // 
            this.TxtNombrePaciente.Location = new System.Drawing.Point(75, 31);
            this.TxtNombrePaciente.Name = "TxtNombrePaciente";
            this.TxtNombrePaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtNombrePaciente.TabIndex = 2;
            // 
            // TxtApellidoPaciente
            // 
            this.TxtApellidoPaciente.Location = new System.Drawing.Point(413, 31);
            this.TxtApellidoPaciente.Name = "TxtApellidoPaciente";
            this.TxtApellidoPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtApellidoPaciente.TabIndex = 3;
            // 
            // CmbDiscapacidad
            // 
            this.CmbDiscapacidad.FormattingEnabled = true;
            this.CmbDiscapacidad.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CmbDiscapacidad.Location = new System.Drawing.Point(632, 57);
            this.CmbDiscapacidad.Name = "CmbDiscapacidad";
            this.CmbDiscapacidad.Size = new System.Drawing.Size(60, 21);
            this.CmbDiscapacidad.TabIndex = 21;
            // 
            // TxtNroDocumento
            // 
            this.TxtNroDocumento.Location = new System.Drawing.Point(287, 58);
            this.TxtNroDocumento.Name = "TxtNroDocumento";
            this.TxtNroDocumento.Size = new System.Drawing.Size(124, 20);
            this.TxtNroDocumento.TabIndex = 4;
            // 
            // TxtObraSocialPaciente
            // 
            this.TxtObraSocialPaciente.Location = new System.Drawing.Point(91, 84);
            this.TxtObraSocialPaciente.Name = "TxtObraSocialPaciente";
            this.TxtObraSocialPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtObraSocialPaciente.TabIndex = 5;
            // 
            // TxtNroAfiliado
            // 
            this.TxtNroAfiliado.Location = new System.Drawing.Point(471, 110);
            this.TxtNroAfiliado.Name = "TxtNroAfiliado";
            this.TxtNroAfiliado.Size = new System.Drawing.Size(221, 20);
            this.TxtNroAfiliado.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Terapia:";
            // 
            // TxtTerapiaPaciente
            // 
            this.TxtTerapiaPaciente.Location = new System.Drawing.Point(91, 110);
            this.TxtTerapiaPaciente.Name = "TxtTerapiaPaciente";
            this.TxtTerapiaPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtTerapiaPaciente.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Certificado de Discapacidad:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
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
            this.label6.Location = new System.Drawing.Point(393, 113);
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
            this.label2.Location = new System.Drawing.Point(360, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Obra social:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de documento:";
            // 
            // CmbTipoDocumento
            // 
            this.CmbTipoDocumento.FormattingEnabled = true;
            this.CmbTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "DEA",
            "LE",
            "LC"});
            this.CmbTipoDocumento.Location = new System.Drawing.Point(132, 57);
            this.CmbTipoDocumento.Name = "CmbTipoDocumento";
            this.CmbTipoDocumento.Size = new System.Drawing.Size(120, 21);
            this.CmbTipoDocumento.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nro:";
            // 
            // TabABM
            // 
            this.TabABM.Controls.Add(this.textBox8);
            this.TabABM.Controls.Add(this.textBox7);
            this.TabABM.Controls.Add(this.textBox6);
            this.TabABM.Controls.Add(this.textBox5);
            this.TabABM.Controls.Add(this.textBox2);
            this.TabABM.Controls.Add(this.LblTitulo);
            this.TabABM.Controls.Add(this.button1);
            this.TabABM.Controls.Add(this.label11);
            this.TabABM.Controls.Add(this.textBox1);
            this.TabABM.Location = new System.Drawing.Point(4, 22);
            this.TabABM.Name = "TabABM";
            this.TabABM.Padding = new System.Windows.Forms.Padding(3);
            this.TabABM.Size = new System.Drawing.Size(756, 498);
            this.TabABM.TabIndex = 1;
            this.TabABM.Text = "ABM Terapeuta";
            this.TabABM.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(240, 126);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(240, 152);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(240, 178);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(240, 204);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(166, 14);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(160, 24);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Alta de terapeutas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "label11";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // CmbHorarios
            // 
            this.CmbHorarios.FormattingEnabled = true;
            this.CmbHorarios.Location = new System.Drawing.Point(251, 109);
            this.CmbHorarios.Name = "CmbHorarios";
            this.CmbHorarios.Size = new System.Drawing.Size(181, 21);
            this.CmbHorarios.TabIndex = 22;
            // 
            // LblHorarios
            // 
            this.LblHorarios.AutoSize = true;
            this.LblHorarios.Location = new System.Drawing.Point(251, 93);
            this.LblHorarios.Name = "LblHorarios";
            this.LblHorarios.Size = new System.Drawing.Size(59, 13);
            this.LblHorarios.TabIndex = 23;
            this.LblHorarios.Text = "Terapeuta:";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 524);
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
            this.TabABM.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblHorarios;
        private System.Windows.Forms.ComboBox CmbHorarios;
    }
}