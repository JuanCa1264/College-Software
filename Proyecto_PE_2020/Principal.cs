using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PE_2020.Vistas;

namespace Proyecto_PE_2020
{
    public partial class frmPrincipal : Form
    {


        public frmPrincipal()
        {
            InitializeComponent();

        }


        private void administraciónDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno a = new frmAlumno();
            a.MdiParent = this;
            a.Show();
            
        }

        private void administraciónDePonderacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPonderaciones p = new frmPonderaciones();
            p.MdiParent = this;
            p.Show();
        }

        private void ingresarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas n = new frmNotas();
            n.MdiParent = this;
            n.Show();
        }

        private void estadoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalle d = new frmDetalle();
            d.MdiParent = this;
            d.Show();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport1 r1 = new frmReport1();
            r1.MdiParent = this;
            r1.Show();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport2 r2 = new frmReport2();
            r2.MdiParent = this;
            r2.Show();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport3 r3 = new frmReport3();
            r3.MdiParent = this;
            r3.Show();
        }

        private void reporte4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport4 r4 = new frmReport4();
            r4.MdiParent = this;
            r4.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
