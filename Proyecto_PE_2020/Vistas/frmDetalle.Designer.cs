namespace Proyecto_PE_2020.Vistas
{
    partial class frmDetalle
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
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcSumario = new System.Windows.Forms.TabControl();
            this.tabPrimerB = new System.Windows.Forms.TabPage();
            this.dgvPrimerSumario = new System.Windows.Forms.DataGridView();
            this.modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSegundoB = new System.Windows.Forms.TabPage();
            this.dgvSegundoSumario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimerAsis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSegundaAsis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSegundaAsistencia = new System.Windows.Forms.ComboBox();
            this.cmbPrimerAsistencia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrimerTotal = new System.Windows.Forms.TextBox();
            this.txtSegundoNota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tbcSumario.SuspendLayout();
            this.tabPrimerB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerSumario)).BeginInit();
            this.tabSegundoB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundoSumario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(127, 24);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(206, 21);
            this.cmbAlumno.TabIndex = 3;
            this.cmbAlumno.SelectionChangeCommitted += new System.EventHandler(this.cmbAlumno_SelectionChangeCommitted);
            this.cmbAlumno.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbAlumno_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Alumno:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbcSumario);
            this.groupBox1.Location = new System.Drawing.Point(31, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 375);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Académico";
            // 
            // tbcSumario
            // 
            this.tbcSumario.Controls.Add(this.tabPrimerB);
            this.tbcSumario.Controls.Add(this.tabSegundoB);
            this.tbcSumario.Location = new System.Drawing.Point(4, 22);
            this.tbcSumario.Name = "tbcSumario";
            this.tbcSumario.SelectedIndex = 0;
            this.tbcSumario.Size = new System.Drawing.Size(875, 342);
            this.tbcSumario.TabIndex = 0;
            // 
            // tabPrimerB
            // 
            this.tabPrimerB.Controls.Add(this.txtPrimerTotal);
            this.tabPrimerB.Controls.Add(this.label6);
            this.tabPrimerB.Controls.Add(this.cmbPrimerAsistencia);
            this.tabPrimerB.Controls.Add(this.label5);
            this.tabPrimerB.Controls.Add(this.label2);
            this.tabPrimerB.Controls.Add(this.txtPrimerAsis);
            this.tabPrimerB.Controls.Add(this.dgvPrimerSumario);
            this.tabPrimerB.Location = new System.Drawing.Point(4, 22);
            this.tabPrimerB.Name = "tabPrimerB";
            this.tabPrimerB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimerB.Size = new System.Drawing.Size(867, 316);
            this.tabPrimerB.TabIndex = 0;
            this.tabPrimerB.Text = "Primer Año de Bachillerato";
            this.tabPrimerB.UseVisualStyleBackColor = true;
            // 
            // dgvPrimerSumario
            // 
            this.dgvPrimerSumario.AllowUserToAddRows = false;
            this.dgvPrimerSumario.AllowUserToDeleteRows = false;
            this.dgvPrimerSumario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimerSumario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modulo,
            this.notaM});
            this.dgvPrimerSumario.Location = new System.Drawing.Point(6, 64);
            this.dgvPrimerSumario.Name = "dgvPrimerSumario";
            this.dgvPrimerSumario.ReadOnly = true;
            this.dgvPrimerSumario.Size = new System.Drawing.Size(855, 246);
            this.dgvPrimerSumario.TabIndex = 0;
            // 
            // modulo
            // 
            this.modulo.HeaderText = "Módulo";
            this.modulo.Name = "modulo";
            this.modulo.ReadOnly = true;
            // 
            // notaM
            // 
            this.notaM.HeaderText = "Nota de Módulo";
            this.notaM.Name = "notaM";
            this.notaM.ReadOnly = true;
            // 
            // tabSegundoB
            // 
            this.tabSegundoB.Controls.Add(this.txtSegundoNota);
            this.tabSegundoB.Controls.Add(this.label7);
            this.tabSegundoB.Controls.Add(this.cmbSegundaAsistencia);
            this.tabSegundoB.Controls.Add(this.label4);
            this.tabSegundoB.Controls.Add(this.label3);
            this.tabSegundoB.Controls.Add(this.txtSegundaAsis);
            this.tabSegundoB.Controls.Add(this.dgvSegundoSumario);
            this.tabSegundoB.Location = new System.Drawing.Point(4, 22);
            this.tabSegundoB.Name = "tabSegundoB";
            this.tabSegundoB.Padding = new System.Windows.Forms.Padding(3);
            this.tabSegundoB.Size = new System.Drawing.Size(867, 316);
            this.tabSegundoB.TabIndex = 1;
            this.tabSegundoB.Text = "Segundo Año de Bachillerato";
            this.tabSegundoB.UseVisualStyleBackColor = true;
            // 
            // dgvSegundoSumario
            // 
            this.dgvSegundoSumario.AllowUserToAddRows = false;
            this.dgvSegundoSumario.AllowUserToDeleteRows = false;
            this.dgvSegundoSumario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegundoSumario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSegundoSumario.Location = new System.Drawing.Point(6, 64);
            this.dgvSegundoSumario.Name = "dgvSegundoSumario";
            this.dgvSegundoSumario.ReadOnly = true;
            this.dgvSegundoSumario.Size = new System.Drawing.Size(854, 246);
            this.dgvSegundoSumario.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Módulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nota de Módulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(337, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(217, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Confirmar Sumario Académico";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asistencia:";
            // 
            // txtPrimerAsis
            // 
            this.txtPrimerAsis.Location = new System.Drawing.Point(403, 38);
            this.txtPrimerAsis.Name = "txtPrimerAsis";
            this.txtPrimerAsis.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerAsis.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asistencia:";
            // 
            // txtSegundaAsis
            // 
            this.txtSegundaAsis.Location = new System.Drawing.Point(405, 38);
            this.txtSegundaAsis.Name = "txtSegundaAsis";
            this.txtSegundaAsis.Size = new System.Drawing.Size(100, 20);
            this.txtSegundaAsis.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Asistencia de Aprobación:";
            // 
            // cmbSegundaAsistencia
            // 
            this.cmbSegundaAsistencia.FormattingEnabled = true;
            this.cmbSegundaAsistencia.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cmbSegundaAsistencia.Location = new System.Drawing.Point(142, 38);
            this.cmbSegundaAsistencia.Name = "cmbSegundaAsistencia";
            this.cmbSegundaAsistencia.Size = new System.Drawing.Size(121, 21);
            this.cmbSegundaAsistencia.TabIndex = 6;
            // 
            // cmbPrimerAsistencia
            // 
            this.cmbPrimerAsistencia.FormattingEnabled = true;
            this.cmbPrimerAsistencia.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cmbPrimerAsistencia.Location = new System.Drawing.Point(142, 38);
            this.cmbPrimerAsistencia.Name = "cmbPrimerAsistencia";
            this.cmbPrimerAsistencia.Size = new System.Drawing.Size(121, 21);
            this.cmbPrimerAsistencia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Asistencia de Aprobación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Notal Académica:";
            // 
            // txtPrimerTotal
            // 
            this.txtPrimerTotal.Location = new System.Drawing.Point(761, 38);
            this.txtPrimerTotal.Name = "txtPrimerTotal";
            this.txtPrimerTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerTotal.TabIndex = 10;
            // 
            // txtSegundoNota
            // 
            this.txtSegundoNota.Location = new System.Drawing.Point(760, 38);
            this.txtSegundoNota.Name = "txtSegundoNota";
            this.txtSegundoNota.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoNota.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notal Académica:";
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 494);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.label1);
            this.Name = "frmDetalle";
            this.Text = "frmDetalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.tbcSumario.ResumeLayout(false);
            this.tabPrimerB.ResumeLayout(false);
            this.tabPrimerB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerSumario)).EndInit();
            this.tabSegundoB.ResumeLayout(false);
            this.tabSegundoB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundoSumario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tbcSumario;
        private System.Windows.Forms.TabPage tabPrimerB;
        private System.Windows.Forms.TabPage tabSegundoB;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvPrimerSumario;
        private System.Windows.Forms.DataGridView dgvSegundoSumario;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimerAsis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSegundaAsis;
        private System.Windows.Forms.ComboBox cmbPrimerAsistencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSegundaAsistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimerTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSegundoNota;
        private System.Windows.Forms.Label label7;
    }
}