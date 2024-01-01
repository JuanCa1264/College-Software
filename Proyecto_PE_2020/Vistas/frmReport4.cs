using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace Proyecto_PE_2020.Vistas
{
    public partial class frmReport4 : Form
    {

        ParameterFields parametros = new ParameterFields();
        ParameterField parametro = new ParameterField();
        ParameterDiscreteValue valorParametro = new ParameterDiscreteValue();
        Project_PE_2020Entities4 contexto = new Project_PE_2020Entities4();

        public frmReport4()
        {
            InitializeComponent();
        }

        private void frmReport4_Load(object sender, EventArgs e){
        
        
        }
        



        

        private void btnReporte_Click(object sender, EventArgs e)
        {
            parametro.ParameterValueType = ParameterValueKind.NumberParameter;
            parametro.Name = "@carnet";
            valorParametro.Value = int.Parse(txtCarnet.Text.ToString());

            parametro.CurrentValues.Add(valorParametro);

            parametros.Add(parametro);

            crystalReportViewer1.ParameterFieldInfo = parametros;

            rptReport4 rpt = new rptReport4();
            crystalReportViewer1.ReportSource = rpt;
        }



    }
}
