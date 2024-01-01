namespace Proyecto_PE_2020
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDePonderacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeAlumnosToolStripMenuItem,
            this.administraciónDeNotasToolStripMenuItem,
            this.administraciónDePonderacionesToolStripMenuItem,
            this.salirDeLaAplicaciónToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónDeAlumnosToolStripMenuItem
            // 
            this.administraciónDeAlumnosToolStripMenuItem.Name = "administraciónDeAlumnosToolStripMenuItem";
            this.administraciónDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.administraciónDeAlumnosToolStripMenuItem.Text = "Administración de Alumnos";
            this.administraciónDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.administraciónDeAlumnosToolStripMenuItem_Click);
            // 
            // administraciónDeNotasToolStripMenuItem
            // 
            this.administraciónDeNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNotasToolStripMenuItem,
            this.estadoDeAlumnoToolStripMenuItem});
            this.administraciónDeNotasToolStripMenuItem.Name = "administraciónDeNotasToolStripMenuItem";
            this.administraciónDeNotasToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.administraciónDeNotasToolStripMenuItem.Text = "Administración de Notas";
            // 
            // ingresarNotasToolStripMenuItem
            // 
            this.ingresarNotasToolStripMenuItem.Name = "ingresarNotasToolStripMenuItem";
            this.ingresarNotasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ingresarNotasToolStripMenuItem.Text = "Ingresar Notas";
            this.ingresarNotasToolStripMenuItem.Click += new System.EventHandler(this.ingresarNotasToolStripMenuItem_Click);
            // 
            // estadoDeAlumnoToolStripMenuItem
            // 
            this.estadoDeAlumnoToolStripMenuItem.Name = "estadoDeAlumnoToolStripMenuItem";
            this.estadoDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.estadoDeAlumnoToolStripMenuItem.Text = "Estado de Alumno";
            this.estadoDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.estadoDeAlumnoToolStripMenuItem_Click);
            // 
            // administraciónDePonderacionesToolStripMenuItem
            // 
            this.administraciónDePonderacionesToolStripMenuItem.Name = "administraciónDePonderacionesToolStripMenuItem";
            this.administraciónDePonderacionesToolStripMenuItem.Size = new System.Drawing.Size(197, 20);
            this.administraciónDePonderacionesToolStripMenuItem.Text = "Administración de Ponderaciones";
            this.administraciónDePonderacionesToolStripMenuItem.Click += new System.EventHandler(this.administraciónDePonderacionesToolStripMenuItem_Click);
            // 
            // salirDeLaAplicaciónToolStripMenuItem
            // 
            this.salirDeLaAplicaciónToolStripMenuItem.Name = "salirDeLaAplicaciónToolStripMenuItem";
            this.salirDeLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.salirDeLaAplicaciónToolStripMenuItem.Text = "Salir de la Aplicación";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporte1ToolStripMenuItem,
            this.reporte2ToolStripMenuItem,
            this.reporte3ToolStripMenuItem,
            this.reporte4ToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporte1ToolStripMenuItem
            // 
            this.reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            this.reporte1ToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.reporte1ToolStripMenuItem.Text = "Reporte Alumnos por Año Académico";
            this.reporte1ToolStripMenuItem.Click += new System.EventHandler(this.reporte1ToolStripMenuItem_Click);
            // 
            // reporte2ToolStripMenuItem
            // 
            this.reporte2ToolStripMenuItem.Name = "reporte2ToolStripMenuItem";
            this.reporte2ToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.reporte2ToolStripMenuItem.Text = "Reporte de Módulos Académicos";
            this.reporte2ToolStripMenuItem.Click += new System.EventHandler(this.reporte2ToolStripMenuItem_Click);
            // 
            // reporte3ToolStripMenuItem
            // 
            this.reporte3ToolStripMenuItem.Name = "reporte3ToolStripMenuItem";
            this.reporte3ToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.reporte3ToolStripMenuItem.Text = "Reporte de Ponderaciones para Evaluaciones";
            this.reporte3ToolStripMenuItem.Click += new System.EventHandler(this.reporte3ToolStripMenuItem_Click);
            // 
            // reporte4ToolStripMenuItem
            // 
            this.reporte4ToolStripMenuItem.Name = "reporte4ToolStripMenuItem";
            this.reporte4ToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.reporte4ToolStripMenuItem.Text = "Reporte de Notas para Alumno";
            this.reporte4ToolStripMenuItem.Click += new System.EventHandler(this.reporte4ToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 463);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDePonderacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeLaAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte4ToolStripMenuItem;
    }
}

