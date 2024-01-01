using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PE_2020.Clases;

namespace Proyecto_PE_2020.Vistas
{
    public partial class frmPonderaciones : Form
    {


        Project_PE_2020Entities4 contexto = new Project_PE_2020Entities4();
        string aux = string.Empty;
        Ponderaciones p = new Ponderaciones();
        decimal suma;
        
        public frmPonderaciones()
        {
            InitializeComponent();


            
            dgvPonderaciones.DataSource = cargarTabla();
            
        }

        void cargarPonderacion()
        {
            cmbPrimerEx.DataSource = contexto.Ponderaciones.ToList();
            cmbPrimerEx.ValueMember = "idPon";
            cmbPrimerEx.DisplayMember = "ponderacion";

            cmbSegundoEx.DataSource = contexto.Ponderaciones.ToList();
            cmbSegundoEx.ValueMember = "idPon";
            cmbSegundoEx.DisplayMember = "ponderacion";

            cmbTercerEx.DataSource = contexto.Ponderaciones.ToList();
            cmbTercerEx.ValueMember = "idPon";
            cmbTercerEx.DisplayMember = "ponderacion";

            cmbCuartoEx.DataSource = contexto.Ponderaciones.ToList();
            cmbCuartoEx.ValueMember = "idPon";
            cmbCuartoEx.DisplayMember = "ponderacion";

            
            cmbActividad.DataSource = contexto.Ponderaciones.ToList();
            cmbActividad.ValueMember = "idPon";
            cmbActividad.DisplayMember = "ponderacion";
            
        }


       

        void sumar()
        {


            suma = 0;

            p.idPon = int.Parse(cmbPrimerEx.SelectedValue.ToString());
            Ponderaciones po = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma += po.ponderacion;


            p = new Ponderaciones();

            
            p.idPon = int.Parse(cmbSegundoEx.SelectedValue.ToString());
            Ponderaciones po1 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma += po1.ponderacion;

            p = new Ponderaciones();

            p.idPon = int.Parse(cmbTercerEx.SelectedValue.ToString());
            Ponderaciones po2 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma += po2.ponderacion;

            p = new Ponderaciones();

            p.idPon = int.Parse(cmbCuartoEx.SelectedValue.ToString());
            Ponderaciones po3 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma += po3.ponderacion;

            p = new Ponderaciones();

            p.idPon = int.Parse(cmbActividad.SelectedValue.ToString());
            Ponderaciones po4 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma += po4.ponderacion;


            txtSuma.Text = suma.ToString();


            if (txtSuma.Text.Equals("1.00"))
            {
                txtSuma.ForeColor = Color.Aqua;
            }
            else
            {
                txtSuma.ForeColor = Color.Red;
            }


        }



        List<EvaluacionPonderacion> cargarTabla()
        {

            using (var ctx = new Project_PE_2020Entities4())
            {
                var query = from e in ctx.Evaluacion
                            join p in ctx.Ponderaciones on e.idPon equals p.idPon
                            select new EvaluacionPonderacion
                            {
                                id = e.idEv,
                                evaluacion = e.evaluacion1,
                                ponderacion = p.ponderacion
                            };

                return query.ToList();

            }

                            

            }
                    

        
        private void frmPonderaciones_Load(object sender, EventArgs e)
        {
            cargarPonderacion();


            sumar();

            
        }

  

        private void cmbPrimerEx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            sumar();

            p.idPon = int.Parse(cmbPrimerEx.SelectedValue.ToString());
            Ponderaciones po4 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma = suma - po4.ponderacion;

            
        }

        private void cmbSegundoEx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            sumar();
        }

        private void cmbTercerEx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            sumar();

            p.idPon = int.Parse(cmbTercerEx.SelectedValue.ToString());
            Ponderaciones po4 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma = suma - po4.ponderacion;

        }

    

        private void cmbCuartoEx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            sumar();

            p.idPon = int.Parse(cmbCuartoEx.SelectedValue.ToString());
            Ponderaciones po4 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma = suma - po4.ponderacion;

        }

       

        private void cmbActividad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            sumar();

            p.idPon = int.Parse(cmbActividad.SelectedValue.ToString());
            Ponderaciones po4 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma = suma - po4.ponderacion;

        }

       

        private void cmbTercerEx_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
            sumar();

            p.idPon = int.Parse(cmbTercerEx.SelectedValue.ToString());
            Ponderaciones po4 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma = suma - po4.ponderacion;

        }

        private void cmbCuartoEx_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
            sumar();

            p.idPon = int.Parse(cmbCuartoEx.SelectedValue.ToString());
            Ponderaciones po4 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma = suma - po4.ponderacion;
        }

        private void cmbActividad_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
            sumar();

            p.idPon = int.Parse(cmbActividad.SelectedValue.ToString());
            Ponderaciones po4 = contexto.Ponderaciones.FirstOrDefault(x => x.idPon == p.idPon);

            suma = suma - po4.ponderacion;
        }

        private void btmModificar_Click(object sender, EventArgs e)
        {

            cargar();

        }

        

        void cargar()
        {

            Evaluacion e = new Evaluacion();

            e = contexto.Evaluacion.FirstOrDefault(x => x.idEv == 1);

            e.idPon = int.Parse(cmbPrimerEx.SelectedValue.ToString());

            contexto.SaveChanges();

            //

            e = new Evaluacion();

            e = contexto.Evaluacion.FirstOrDefault(x => x.idEv == 2);

            e.idPon = int.Parse(cmbSegundoEx.SelectedValue.ToString());

            contexto.SaveChanges();

            //

            e = new Evaluacion();

            e = contexto.Evaluacion.FirstOrDefault(x => x.idEv == 3);

            e.idPon = int.Parse(cmbTercerEx.SelectedValue.ToString());

            contexto.SaveChanges();


            //

            e = new Evaluacion();

            e = contexto.Evaluacion.FirstOrDefault(x => x.idEv == 4);

            e.idPon = int.Parse(cmbCuartoEx.SelectedValue.ToString());

            contexto.SaveChanges();

            //

            e = new Evaluacion();

            e = contexto.Evaluacion.FirstOrDefault(x => x.idEv == 5);

            e.idPon = int.Parse(cmbActividad.SelectedValue.ToString());

            contexto.SaveChanges();

            //

            dgvPonderaciones.DataSource = cargarTabla();

        }



    }
}
