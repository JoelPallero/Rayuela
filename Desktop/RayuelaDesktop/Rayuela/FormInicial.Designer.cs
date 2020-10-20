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
            this.TabABM = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TxtNombrePaciente = new System.Windows.Forms.TextBox();
            this.TxtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.TxtNroDocumento = new System.Windows.Forms.TextBox();
            this.TxtObraSocialPaciente = new System.Windows.Forms.TextBox();
            this.TxtNroAfiliado = new System.Windows.Forms.TextBox();
            this.TxtTerapiaPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbTerapeuta = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbDiscapacidad = new System.Windows.Forms.ComboBox();
            this.GpPaciente = new System.Windows.Forms.GroupBox();
            this.GpTurnos = new System.Windows.Forms.GroupBox();
            this.BtnSchedule = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabAgenda.SuspendLayout();
            this.GpPaciente.SuspendLayout();
            this.GpTurnos.SuspendLayout();
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
            // TabABM
            // 
            this.TabABM.Location = new System.Drawing.Point(4, 22);
            this.TabABM.Name = "TabABM";
            this.TabABM.Padding = new System.Windows.Forms.Padding(3);
            this.TabABM.Size = new System.Drawing.Size(395, 421);
            this.TabABM.TabIndex = 1;
            this.TabABM.Text = "ABM Terapeuta";
            this.TabABM.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
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
            this.TxtNroAfiliado.Location = new System.Drawing.Point(471, 87);
            this.TxtNroAfiliado.Name = "TxtNroAfiliado";
            this.TxtNroAfiliado.Size = new System.Drawing.Size(221, 20);
            this.TxtNroAfiliado.TabIndex = 6;
            // 
            // TxtTerapiaPaciente
            // 
            this.TxtTerapiaPaciente.Location = new System.Drawing.Point(91, 110);
            this.TxtTerapiaPaciente.Name = "TxtTerapiaPaciente";
            this.TxtTerapiaPaciente.Size = new System.Drawing.Size(279, 20);
            this.TxtTerapiaPaciente.TabIndex = 8;
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
            // CmbTipoDocumento
            // 
            this.CmbTipoDocumento.FormattingEnabled = true;
            this.CmbTipoDocumento.Location = new System.Drawing.Point(132, 57);
            this.CmbTipoDocumento.Name = "CmbTipoDocumento";
            this.CmbTipoDocumento.Size = new System.Drawing.Size(120, 21);
            this.CmbTipoDocumento.TabIndex = 14;
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "N° de afiliado:";
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
            // CmbDiscapacidad
            // 
            this.CmbDiscapacidad.FormattingEnabled = true;
            this.CmbDiscapacidad.Location = new System.Drawing.Point(632, 57);
            this.CmbDiscapacidad.Name = "CmbDiscapacidad";
            this.CmbDiscapacidad.Size = new System.Drawing.Size(60, 21);
            this.CmbDiscapacidad.TabIndex = 21;
            // 
            // GpPaciente
            // 
            this.GpPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // GpTurnos
            // 
            this.GpTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpTurnos.Controls.Add(this.BtnSchedule);
            this.GpTurnos.Controls.Add(this.monthCalendar1);
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
            this.BtnSchedule.Location = new System.Drawing.Point(12, 256);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.Size = new System.Drawing.Size(112, 42);
            this.BtnSchedule.TabIndex = 21;
            this.BtnSchedule.Text = "GuardarTurno";
            this.BtnSchedule.UseVisualStyleBackColor = true;
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
            this.GpPaciente.ResumeLayout(false);
            this.GpPaciente.PerformLayout();
            this.GpTurnos.ResumeLayout(false);
            this.GpTurnos.PerformLayout();
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
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
    }
}