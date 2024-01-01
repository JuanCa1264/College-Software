using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PE_2020.Vistas
{
    public partial class frmDetalle : Form
    {

        Project_PE_2020Entities4 contexto = new Project_PE_2020Entities4();
        Alumno a = new Alumno();
        Modulo m = new Modulo();
        Modulo m1 = new Modulo();
        Modulo m2 = new Modulo();
        Modulo m3 = new Modulo();
        Modulo m4 = new Modulo();
        Modulo m5 = new Modulo();
        Modulo m6 = new Modulo();
        Modulo m7 = new Modulo();
        Modulo m8 = new Modulo();
        Modulo m9 = new Modulo();
        Alumno a1 = new Alumno();
        Detalle_Alumno da = new Detalle_Alumno();

        Detalle_Nota n = new Detalle_Nota();

        public frmDetalle()
        {
            InitializeComponent();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarAlumno();
            tbcSumario.Visible = false;
        }


        void cargarTablaP() {
        

        
        }


        void cargarAlumno()
        {
            cmbAlumno.DataSource = contexto.Alumno.ToList();
            cmbAlumno.ValueMember = "carnet";
            cmbAlumno.DisplayMember = "nombre";
        }

        private void cmbAlumno_Format(object sender, ListControlConvertEventArgs e)
        {

            string lastname = ((Alumno)e.ListItem).nombre;
            string firstname = ((Alumno)e.ListItem).apellido;
            e.Value = lastname + " " + firstname;

            
        }

        private void cmbAlumno_SelectionChangeCommitted(object sender, EventArgs e)
        {

            decimal notaTotal = decimal.Parse("0.0");
            dgvPrimerSumario.Rows.Clear();
            dgvSegundoSumario.Rows.Clear();
            

            a.carnet = int.Parse(cmbAlumno.SelectedValue.ToString());

            a1 = contexto.Alumno.FirstOrDefault(x => x.carnet == a.carnet);

            if (a1.idCa == 1)
            {
                m = contexto.Modulo.FirstOrDefault(x=>x.idMod == 1);
                m1 = contexto.Modulo.FirstOrDefault(x => x.idMod == 2);
                m2 = contexto.Modulo.FirstOrDefault(x => x.idMod == 3);
                m3 = contexto.Modulo.FirstOrDefault(x => x.idMod == 4);
                m4 = contexto.Modulo.FirstOrDefault(x => x.idMod == 5);
                //
                tbcSumario.TabPages.Clear();
                

                tbcSumario.TabPages.Remove(tabSegundoB);
               

                tbcSumario.TabPages.Add(tabPrimerB);



                string nota = contexto.CalcularNotaModulo(a1.carnet, 1).FirstOrDefault().ToString();
                string nota1 = contexto.CalcularNotaModulo(a1.carnet, 2).FirstOrDefault().ToString();
                string nota2 = contexto.CalcularNotaModulo(a1.carnet, 3).FirstOrDefault().ToString();
                string nota3 = contexto.CalcularNotaModulo(a1.carnet, 4).FirstOrDefault().ToString();
                string nota4 = contexto.CalcularNotaModulo(a1.carnet, 5).FirstOrDefault().ToString();

                string[] row1 = new string[] { m.nombre, nota};
                string[] row2 = new string[] { m1.nombre, nota1 };
                string[] row3 = new string[] { m2.nombre, nota2 };
                string[] row4 = new string[] { m3.nombre, nota3 };
                string[] row5 = new string[] { m4.nombre, nota4 };

                dgvPrimerSumario.Rows.Add(row1);
                dgvPrimerSumario.Rows.Add(row2);
                dgvPrimerSumario.Rows.Add(row3);
                dgvPrimerSumario.Rows.Add(row4);
                dgvPrimerSumario.Rows.Add(row5);

                foreach (DataGridViewRow row in dgvPrimerSumario.Rows)
                {
                    notaTotal += decimal.Parse(Convert.ToString(row.Cells["notaM"].Value));
                }
                txtPrimerTotal.Text = (notaTotal/5).ToString();
                tbcSumario.Visible = true;

                
                tbcSumario.Visible = true;

            }

            else if (a1.idCa == 2)
            {

                m5 = contexto.Modulo.FirstOrDefault(x => x.idMod == 6);
                m6 = contexto.Modulo.FirstOrDefault(x => x.idMod == 7);
                m7 = contexto.Modulo.FirstOrDefault(x => x.idMod == 8);
                m8 = contexto.Modulo.FirstOrDefault(x => x.idMod == 9);
                m9 = contexto.Modulo.FirstOrDefault(x => x.idMod == 10);
                

                tbcSumario.TabPages.Clear();

                tbcSumario.TabPages.Remove(tabPrimerB);


                tbcSumario.TabPages.Add(tabSegundoB);


                string nota = contexto.CalcularNotaModulo(a1.carnet, 6).FirstOrDefault().ToString();
                string nota1 = contexto.CalcularNotaModulo(a1.carnet, 7).FirstOrDefault().ToString();
                string nota2 = contexto.CalcularNotaModulo(a1.carnet, 8).FirstOrDefault().ToString();
                string nota3 = contexto.CalcularNotaModulo(a1.carnet, 9).FirstOrDefault().ToString();
                string nota4 = contexto.CalcularNotaModulo(a1.carnet, 10).FirstOrDefault().ToString();

                string[] row1 = new string[] { m5.nombre, nota };
                string[] row2 = new string[] { m6.nombre, nota1 };
                string[] row3 = new string[] { m7.nombre, nota2 };
                string[] row4 = new string[] { m8.nombre, nota3 };
                string[] row5 = new string[] { m9.nombre, nota4 };

                dgvSegundoSumario.Rows.Add(row1);
                dgvSegundoSumario.Rows.Add(row2);
                dgvSegundoSumario.Rows.Add(row3);
                dgvSegundoSumario.Rows.Add(row4);
                dgvSegundoSumario.Rows.Add(row5);

                foreach (DataGridViewRow row in dgvSegundoSumario.Rows)
                {
                    notaTotal += decimal.Parse(Convert.ToString(row.Cells["dataGridViewTextBoxColumn3"].Value));
                }
                txtSegundoNota.Text = (notaTotal/5).ToString();
                tbcSumario.Visible = true;

                
                
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                

                if (a1.idCa == 1)
                {

                    int asis = int.Parse(cmbPrimerAsistencia.SelectedItem.ToString());

                    int asisA = int.Parse(txtPrimerAsis.Text);

                    decimal notaT = decimal.Parse(txtPrimerTotal.Text);

                    if (!(asisA < asis || notaT < 7))
                    {
                        da.carnet = a1.carnet;
                        da.porcentajeAsistencia = asisA.ToString();
                        da.idCa = 1;
                        da.estado = "Aprobado";
                    }

                    else
                    {
                        da.carnet = a1.carnet;
                        da.porcentajeAsistencia = asisA.ToString();
                        da.idCa = 1;
                        da.estado = "Reprobado";
                    }

                    contexto.Detalle_Alumno.Add(da);
                    contexto.SaveChanges();

                }

                else if (a1.idCa == 2)
                {

                    
                    int asis2 = int.Parse(cmbSegundaAsistencia.SelectedItem.ToString());

                    int asisA2 = int.Parse(txtSegundaAsis.Text);

                    decimal notaT2 = decimal.Parse(txtSegundoNota.Text);

                    if (!(asisA2 < asis2 || notaT2 < 7))
                    {
                        da.carnet = a1.carnet;
                        da.porcentajeAsistencia = asisA2.ToString();
                        da.idCa = 2;
                        da.estado = "Aprobado";
                        
                    }

                    else
                    {
                        da.carnet = a1.carnet;
                        da.porcentajeAsistencia = asisA2.ToString();
                        da.idCa = 2;
                        da.estado = "Reprobado";
                        
                    }

                    contexto.Detalle_Alumno.Add(da);
                    contexto.SaveChanges();
                }

            

            
        }

    }
}
