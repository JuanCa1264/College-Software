namespace Proyecto_PE_2020.Vistas
{
    partial class frmPonderaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPrimerEx = new System.Windows.Forms.ComboBox();
            this.cmbSegundoEx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCuartoEx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTercerEx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPonderaciones = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.btmModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonderaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración de Ponderaciones para Evaluación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Examen:";
            // 
            // cmbPrimerEx
            // 
            this.cmbPrimerEx.FormattingEnabled = true;
            this.cmbPrimerEx.Location = new System.Drawing.Point(161, 67);
            this.cmbPrimerEx.Name = "cmbPrimerEx";
            this.cmbPrimerEx.Size = new System.Drawing.Size(121, 21);
            this.cmbPrimerEx.TabIndex = 2;
            this.cmbPrimerEx.SelectionChangeCommitted += new System.EventHandler(this.cmbPrimerEx_SelectionChangeCommitted);
            // 
            // cmbSegundoEx
            // 
            this.cmbSegundoEx.FormattingEnabled = true;
            this.cmbSegundoEx.Location = new System.Drawing.Point(431, 62);
            this.cmbSegundoEx.Name = "cmbSegundoEx";
            this.cmbSegundoEx.Size = new System.Drawing.Size(121, 21);
            this.cmbSegundoEx.TabIndex = 4;
            this.cmbSegundoEx.SelectionChangeCommitted += new System.EventHandler(this.cmbSegundoEx_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundo Examen:";
            // 
            // cmbCuartoEx
            // 
            this.cmbCuartoEx.FormattingEnabled = true;
            this.cmbCuartoEx.Location = new System.Drawing.Point(161, 137);
            this.cmbCuartoEx.Name = "cmbCuartoEx";
            this.cmbCuartoEx.Size = new System.Drawing.Size(121, 21);
            this.cmbCuartoEx.TabIndex = 6;
            this.cmbCuartoEx.SelectionChangeCommitted += new System.EventHandler(this.cmbCuartoEx_SelectionChangeCommitted_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cuarto Examen:";
            // 
            // cmbTercerEx
            // 
            this.cmbTercerEx.FormattingEnabled = true;
            this.cmbTercerEx.Location = new System.Drawing.Point(705, 67);
            this.cmbTercerEx.Name = "cmbTercerEx";
            this.cmbTercerEx.Size = new System.Drawing.Size(121, 21);
            this.cmbTercerEx.TabIndex = 8;
            this.cmbTercerEx.SelectionChangeCommitted += new System.EventHandler(this.cmbTercerEx_SelectionChangeCommitted_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tercer Examen:";
            // 
            // cmbActividad
            // 
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(431, 137);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(121, 21);
            this.cmbActividad.TabIndex = 10;
            this.cmbActividad.SelectionChangeCommitted += new System.EventHandler(this.cmbActividad_SelectionChangeCommitted_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Actividad Evaluada:";
            // 
            // dgvPonderaciones
            // 
            this.dgvPonderaciones.AllowUserToAddRows = false;
            this.dgvPonderaciones.AllowUserToDeleteRows = false;
            this.dgvPonderaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonderaciones.Location = new System.Drawing.Point(78, 193);
            this.dgvPonderaciones.Name = "dgvPonderaciones";
            this.dgvPonderaciones.ReadOnly = true;
            this.dgvPonderaciones.Size = new System.Drawing.Size(748, 215);
            this.dgvPonderaciones.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contador:";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(765, 143);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(61, 20);
            this.txtSuma.TabIndex = 14;
            // 
            // btmModificar
            // 
            this.btmModificar.Location = new System.Drawing.Point(361, 414);
            this.btmModificar.Name = "btmModificar";
            this.btmModificar.Size = new System.Drawing.Size(151, 23);
            this.btmModificar.TabIndex = 15;
            this.btmModificar.Text = "Modificar Ponderaciones";
            this.btmModificar.UseVisualStyleBackColor = true;
            this.btmModificar.Click += new System.EventHandler(this.btmModificar_Click);
            // 
            // frmPonderaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 454);
            this.Controls.Add(this.btmModificar);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPonderaciones);
            this.Controls.Add(this.cmbActividad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTercerEx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCuartoEx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSegundoEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPrimerEx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPonderaciones";
            this.Text = "frmPonderaciones";
            this.Load += new System.EventHandler(this.frmPonderaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonderaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPrimerEx;
        private System.Windows.Forms.ComboBox cmbSegundoEx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCuartoEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTercerEx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPonderaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Button btmModificar;
    }
}