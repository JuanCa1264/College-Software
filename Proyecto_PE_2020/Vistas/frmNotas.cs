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
    public partial class frmNotas : Form
    {

        Project_PE_2020Entities4 contexto = new Project_PE_2020Entities4();

            Alumno a1 = new Alumno();
            

        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            cargarAlumno();
            tcModulo.Visible = false;
        }



    

        void cargarAlumno()
        {
            cmbAlumno.DataSource = contexto.Alumno.ToList();
            cmbAlumno.ValueMember = "carnet";
            cmbAlumno.DisplayMember = "nombre";


        }


        List<DetalleNota_Alumno_Evaluacion> cargarTabla(int i, int carnet)
        {

            using (var ctx = new Project_PE_2020Entities4())
            {
                var query = from dn in ctx.Detalle_Nota
                            join a in ctx.Alumno on dn.carnet equals a.carnet
                            join e in ctx.Evaluacion on dn.idEv equals e.idEv
                            where dn.idMod == i
                            where dn.carnet == carnet

                            select new DetalleNota_Alumno_Evaluacion
                            {
                                carnet = a.carnet,
                                nombre = a.nombre,
                                apellido = a.apellido,
                                nota = dn.nota,
                                evaluacion = e.evaluacion1

                            };

                return query.ToList();

            }



        }




        private void cmbAlumno_Format(object sender, ListControlConvertEventArgs e)
        {

            string lastname = ((Alumno)e.ListItem).nombre;
            string firstname = ((Alumno)e.ListItem).apellido;
            e.Value = lastname + " " + firstname;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbAlumno_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Alumno a = new Alumno();
            Alumno a1 = new Alumno();

            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());

            a1 = contexto.Alumno.FirstOrDefault(x => x.carnet == a.carnet);



            if (a1.idCa == 1)
            {

                tcModulo.TabPages.Clear();

                tcModulo.TabPages.Remove(tabB);
                tcModulo.TabPages.Remove(tabGeol);
                tcModulo.TabPages.Remove(tabGeog);
                tcModulo.TabPages.Remove(tabDTII);
                tcModulo.TabPages.Remove(tabAE);

                tcModulo.TabPages.Add(tabDT);
                tcModulo.TabPages.Add(tadEF);
                tcModulo.TabPages.Add(tabMA);
                tcModulo.TabPages.Add(tabFI);
                tcModulo.TabPages.Add(tabFIQU);


                dgvDT.DataSource = cargarTabla(1, a1.carnet);
                dgvEF.DataSource = cargarTabla(2, a1.carnet);
                dgvM.DataSource = cargarTabla(3, a1.carnet);
                dgvF.DataSource = cargarTabla(4, a1.carnet);
                dgvFQ.DataSource = cargarTabla(5, a1.carnet);

                cargarTextboxDT();
                cargarTextboxEF();
                cargarTextboxM();
                cargarTextboxF();
                cargarTextboxFQ();


                tcModulo.Visible = true;

            }

            else if (a1.idCa == 2)
            {
                tcModulo.TabPages.Clear();

                tcModulo.TabPages.Remove(tabDT);
                tcModulo.TabPages.Remove(tadEF);
                tcModulo.TabPages.Remove(tabMA);
                tcModulo.TabPages.Remove(tabFI);
                tcModulo.TabPages.Remove(tabFIQU);

                //

                tcModulo.TabPages.Add(tabB);
                tcModulo.TabPages.Add(tabGeol);
                tcModulo.TabPages.Add(tabGeog);
                tcModulo.TabPages.Add(tabDTII);
                tcModulo.TabPages.Add(tabAE);


                dgvBio.DataSource = cargarTabla(6, a1.carnet);
                dgvGeologia.DataSource = cargarTabla(7, a1.carnet);
                dgvGeog.DataSource = cargarTabla(8, a1.carnet);
                dgvDTII.DataSource = cargarTabla(9, a1.carnet);
                dgvAE.DataSource = cargarTabla(10, a1.carnet);


                cargarTextboxBio();
                cargarTextboxGeo();
                cargarTextboxGeog();
                cargarTextboxDTII();
                cargarTextboxAE();

                tcModulo.Visible = true;
            }

            ///
          
            
            


            


        }

        void cargarTextboxDT()
        {
            mskE1.Text = dgvDT.Rows[0].Cells[3].Value.ToString();
            mskE2.Text = dgvDT.Rows[1].Cells[3].Value.ToString();
            mskE3.Text = dgvDT.Rows[2].Cells[3].Value.ToString();
            mskE4.Text = dgvDT.Rows[3].Cells[3].Value.ToString();
            mskActividad.Text = dgvDT.Rows[4].Cells[3].Value.ToString();

        }

        void cargarTextboxEF()
        {
            mskE1EF.Text = dgvEF.Rows[0].Cells[3].Value.ToString();
            mskE2EF.Text = dgvEF.Rows[1].Cells[3].Value.ToString();
            mskE3EF.Text = dgvEF.Rows[2].Cells[3].Value.ToString();
            mskE4EF.Text = dgvEF.Rows[3].Cells[3].Value.ToString();
            mskActividadEF.Text = dgvEF.Rows[4].Cells[3].Value.ToString();

        }




        void cargarTextboxM()
        {
            mskE1M.Text = dgvM.Rows[0].Cells[3].Value.ToString();
            mskE2M.Text = dgvM.Rows[1].Cells[3].Value.ToString();
            mskE3M.Text = dgvM.Rows[2].Cells[3].Value.ToString();
            mskE4M.Text = dgvM.Rows[3].Cells[3].Value.ToString();
            mskActividadM.Text = dgvM.Rows[4].Cells[3].Value.ToString();

        }



        void cargarTextboxF()
        {
            mskE1F.Text = dgvF.Rows[0].Cells[3].Value.ToString();
            mskE2F.Text = dgvF.Rows[1].Cells[3].Value.ToString();
            mskE3F.Text = dgvF.Rows[2].Cells[3].Value.ToString();
            mskE4F.Text = dgvF.Rows[3].Cells[3].Value.ToString();
            mskActividadF.Text = dgvF.Rows[4].Cells[3].Value.ToString();

        }


        void cargarTextboxFQ()
        {
            mskE1FQ.Text = dgvFQ.Rows[0].Cells[3].Value.ToString();
            mskE2FQ.Text = dgvFQ.Rows[1].Cells[3].Value.ToString();
            mskE3FQ.Text = dgvFQ.Rows[2].Cells[3].Value.ToString();
            mskE4FQ.Text = dgvFQ.Rows[3].Cells[3].Value.ToString();
            mskActividadFQ.Text = dgvFQ.Rows[4].Cells[3].Value.ToString();

        }

        void cargarTextboxBio()
        {
            mskE1B.Text = dgvBio.Rows[0].Cells[3].Value.ToString();
            mskE2B.Text = dgvBio.Rows[1].Cells[3].Value.ToString();
            mskE3B.Text = dgvBio.Rows[2].Cells[3].Value.ToString();
            mskE4B.Text = dgvBio.Rows[3].Cells[3].Value.ToString();
            mskActividadB.Text = dgvBio.Rows[4].Cells[3].Value.ToString();

        }


        void cargarTextboxGeo()
        {
            mskE1G.Text = dgvGeologia.Rows[0].Cells[3].Value.ToString();
            mskE2G.Text = dgvGeologia.Rows[1].Cells[3].Value.ToString();
            mskE3G.Text = dgvGeologia.Rows[2].Cells[3].Value.ToString();
            mskE4G.Text = dgvGeologia.Rows[3].Cells[3].Value.ToString();
            mskActividadG.Text = dgvGeologia.Rows[4].Cells[3].Value.ToString();

        }


        void cargarTextboxGeog()
        {
            mskE1Geog.Text = dgvGeog.Rows[0].Cells[3].Value.ToString();
            mskE2Geog.Text = dgvGeog.Rows[1].Cells[3].Value.ToString();
            mskE3Geog.Text = dgvGeog.Rows[2].Cells[3].Value.ToString();
            mskE4Geog.Text = dgvGeog.Rows[3].Cells[3].Value.ToString();
            mskActividadGeog.Text = dgvGeog.Rows[4].Cells[3].Value.ToString();

        }


        void cargarTextboxDTII()
        {

            mskE1DTII.Text = dgvDTII.Rows[0].Cells[3].Value.ToString();
            mskE2DTII.Text = dgvDTII.Rows[1].Cells[3].Value.ToString();
            mskE3DTII.Text = dgvDTII.Rows[2].Cells[3].Value.ToString();
            mskE4DTII.Text = dgvDTII.Rows[3].Cells[3].Value.ToString();
            mskActividadDTII.Text = dgvDTII.Rows[4].Cells[3].Value.ToString();

        }


        void cargarTextboxAE()
        {
            mskE1AE.Text = dgvAE.Rows[0].Cells[3].Value.ToString();
            mskE2AE.Text = dgvAE.Rows[1].Cells[3].Value.ToString();
            mskE3AE.Text = dgvAE.Rows[2].Cells[3].Value.ToString();
            mskE4AE.Text = dgvAE.Rows[3].Cells[3].Value.ToString();
            mskActividadAE.Text = dgvAE.Rows[4].Cells[3].Value.ToString();

        }


        

        void cargarNotaDT()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1.Equals("0.00")){

            
   
                
                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x=>x.idEv == 1).FirstOrDefault(x => x.idMod == 1);
                



                de.nota = decimal.Parse(mskE1.Text);
                
                contexto.SaveChanges();
                
            }

            if (!mskE2.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 1);

                de.nota = decimal.Parse(mskE2.Text);


                contexto.SaveChanges();

            }

            if (!mskE3.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 1);

                de.nota = decimal.Parse(mskE3.Text);


                contexto.SaveChanges();

            }

            if (!mskE4.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 1);

                de.nota = decimal.Parse(mskE4.Text);


                contexto.SaveChanges();

            }


            if (!mskActividad.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 1);

                de.nota = decimal.Parse(mskActividad.Text);


                contexto.SaveChanges();

            }



        }


        void cargarNotaEF()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1EF.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 2);




                de.nota = decimal.Parse(mskE1EF.Text);

                contexto.SaveChanges();

            }

            if (!mskE2EF.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 2);

                de.nota = decimal.Parse(mskE2EF.Text);


                contexto.SaveChanges();

            }

            if (!mskE3EF.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 2);

                de.nota = decimal.Parse(mskE3EF.Text);


                contexto.SaveChanges();

            }

            if (!mskE4EF.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 2);

                de.nota = decimal.Parse(mskE4EF.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadEF.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 2);

                de.nota = decimal.Parse(mskActividadEF.Text);


                contexto.SaveChanges();

            }



        }


        void cargarNotaM()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1M.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 3);




                de.nota = decimal.Parse(mskE1M.Text);

                contexto.SaveChanges();

            }

            if (!mskE2M.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 3);

                de.nota = decimal.Parse(mskE2M.Text);


                contexto.SaveChanges();

            }

            if (!mskE3M.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 3);

                de.nota = decimal.Parse(mskE3M.Text);


                contexto.SaveChanges();

            }

            if (!mskE4M.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 3);

                de.nota = decimal.Parse(mskE4M.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadM.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 3);

                de.nota = decimal.Parse(mskActividadM.Text);


                contexto.SaveChanges();

            }



        }

        void cargarNotaF()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1F.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 4);




                de.nota = decimal.Parse(mskE1F.Text);

                contexto.SaveChanges();

            }

            if (!mskE2F.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 4);

                de.nota = decimal.Parse(mskE2F.Text);


                contexto.SaveChanges();

            }

            if (!mskE3F.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 4);

                de.nota = decimal.Parse(mskE3F.Text);


                contexto.SaveChanges();

            }

            if (!mskE4F.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 4);

                de.nota = decimal.Parse(mskE4F.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadF.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 4);

                de.nota = decimal.Parse(mskActividadF.Text);


                contexto.SaveChanges();

            }



        }


        void cargarNotaFQ()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1FQ.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 5);




                de.nota = decimal.Parse(mskE1FQ.Text);

                contexto.SaveChanges();

            }

            if (!mskE2FQ.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 5);

                de.nota = decimal.Parse(mskE2FQ.Text);


                contexto.SaveChanges();

            }

            if (!mskE3FQ.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 5);

                de.nota = decimal.Parse(mskE3FQ.Text);


                contexto.SaveChanges();

            }

            if (!mskE4FQ.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 5);

                de.nota = decimal.Parse(mskE4FQ.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadFQ.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 5);

                de.nota = decimal.Parse(mskActividadFQ.Text);


                contexto.SaveChanges();

            }



        }


        void cargarNotaB()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1B.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 6);




                de.nota = decimal.Parse(mskE1B.Text);

                contexto.SaveChanges();

            }

            if (!mskE2B.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 6);

                de.nota = decimal.Parse(mskE2B.Text);


                contexto.SaveChanges();

            }

            if (!mskE3B.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 6);

                de.nota = decimal.Parse(mskE3B.Text);


                contexto.SaveChanges();

            }

            if (!mskE4B.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 6);

                de.nota = decimal.Parse(mskE4B.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadB.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 6);

                de.nota = decimal.Parse(mskActividadB.Text);


                contexto.SaveChanges();

            }



        }


        void cargarNotaG()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1G.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 7);




                de.nota = decimal.Parse(mskE1G.Text);

                contexto.SaveChanges();

            }

            if (!mskE2G.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 7);

                de.nota = decimal.Parse(mskE2G.Text);


                contexto.SaveChanges();

            }

            if (!mskE3G.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 7);

                de.nota = decimal.Parse(mskE3G.Text);


                contexto.SaveChanges();

            }

            if (!mskE4G.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 7);

                de.nota = decimal.Parse(mskE4G.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadG.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 7);

                de.nota = decimal.Parse(mskActividadG.Text);


                contexto.SaveChanges();

            }



        }



        void cargarNotaGeog()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1Geog.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 8);




                de.nota = decimal.Parse(mskE1Geog.Text);

                contexto.SaveChanges();

            }

            if (!mskE2Geog.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 8);

                de.nota = decimal.Parse(mskE2Geog.Text);


                contexto.SaveChanges();

            }

            if (!mskE3Geog.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 8);

                de.nota = decimal.Parse(mskE3Geog.Text);


                contexto.SaveChanges();

            }

            if (!mskE4Geog.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 8);

                de.nota = decimal.Parse(mskE4Geog.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadGeog.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 8);

                de.nota = decimal.Parse(mskActividadGeog.Text);


                contexto.SaveChanges();

            }



        }



        void cargarNotaDTII()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1DTII.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 9);




                de.nota = decimal.Parse(mskE1DTII.Text);

                contexto.SaveChanges();

            }

            if (!mskE2DTII.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 9);

                de.nota = decimal.Parse(mskE2DTII.Text);


                contexto.SaveChanges();

            }

            if (!mskE3DTII.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 9);

                de.nota = decimal.Parse(mskE3DTII.Text);


                contexto.SaveChanges();

            }

            if (!mskE4DTII.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 9);

                de.nota = decimal.Parse(mskE4DTII.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadDTII.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 9);

                de.nota = decimal.Parse(mskActividadDTII.Text);


                contexto.SaveChanges();

            }



        }


        void cargarNotaAE()
        {

            Alumno a = new Alumno();




            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());





            if (!mskE1AE.Equals("0.00"))
            {




                Detalle_Nota de = new Detalle_Nota();


                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 1).FirstOrDefault(x => x.idMod == 10);




                de.nota = decimal.Parse(mskE1AE.Text);

                contexto.SaveChanges();

            }

            if (!mskE2AE.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 2).FirstOrDefault(x => x.idMod == 10);

                de.nota = decimal.Parse(mskE2AE.Text);


                contexto.SaveChanges();

            }

            if (!mskE3AE.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 3).FirstOrDefault(x => x.idMod == 10);

                de.nota = decimal.Parse(mskE3AE.Text);


                contexto.SaveChanges();

            }

            if (!mskE4AE.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 4).FirstOrDefault(x => x.idMod == 10);

                de.nota = decimal.Parse(mskE4AE.Text);


                contexto.SaveChanges();

            }


            if (!mskActividadAE.Equals("0.00"))
            {

                Detalle_Nota de = new Detalle_Nota();

                de = contexto.Detalle_Nota.Where(x => x.carnet == a.carnet).Where(x => x.idEv == 5).FirstOrDefault(x => x.idMod == 10);

                de.nota = decimal.Parse(mskActividadAE.Text);


                contexto.SaveChanges();

            }



        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarNotaDT();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvDT.DataSource = cargarTabla(1, a1.carnet);
            
        }

        private void btnGuardarEF_Click(object sender, EventArgs e)
        {
            cargarNotaEF();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvEF.DataSource = cargarTabla(2, a1.carnet);
           
        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            cargarNotaM();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvM.DataSource = cargarTabla(3, a1.carnet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarNotaF();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvF.DataSource = cargarTabla(4, a1.carnet);
        }

        private void btnGuardarFQ_Click(object sender, EventArgs e)
        {
            cargarNotaFQ();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvFQ.DataSource = cargarTabla(5, a1.carnet);
        }

        private void btnGuardarB_Click(object sender, EventArgs e)
        {
            cargarNotaB();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvBio.DataSource = cargarTabla(6, a1.carnet);
        }

        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            cargarNotaG();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvGeologia.DataSource = cargarTabla(7, a1.carnet);
        }

        private void btnGuardarGeog_Click(object sender, EventArgs e)
        {
            cargarNotaGeog();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvGeog.DataSource = cargarTabla(8, a1.carnet);
        }

        private void btnGuardarDTII_Click(object sender, EventArgs e)
        {
            cargarNotaDTII();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvDTII.DataSource = cargarTabla(9, a1.carnet);
        }

        private void btnGuardarAE_Click(object sender, EventArgs e)
        {
            cargarNotaAE();
            a1.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());
            dgvAE.DataSource = cargarTabla(10, a1.carnet);
        }
    }
}
