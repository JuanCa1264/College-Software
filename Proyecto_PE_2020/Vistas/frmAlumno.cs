using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_PE_2020.Vistas
{
    public partial class frmAlumno : Form
    {

        Project_PE_2020Entities4 contexto = new Project_PE_2020Entities4();
        Alumno a = new Alumno();
        string opcion = string.Empty;

        public frmAlumno()
        {
            InitializeComponent();
            cargarTabla();
            cargarCursoA();
        }

        void cargarTabla()
        {
            dgvAlumno.DataSource = contexto.Alumno.ToList();
        }

        void cargarCursoA(){

            cmbCursoA.DataSource = contexto.CursoAcademico.ToList();
            cmbCursoA.ValueMember = "idCa";
            cmbCursoA.DisplayMember = "nombre";

        }

        void cargarAlumno()
        {
            try
            {
                a.carnet = int.Parse(txtCarnet.Text);
                a.nombre = txtNombre.Text;
                a.apellido = txtApellido.Text;
                
                a.idCa = int.Parse(cmbCursoA.SelectedValue.ToString());
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al intentar almacenar los datos del alumno: " + ex.Message);
            }

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            disableTextbox();
            disableButton();
        }


        void disableTextbox(){
            txtCarnet.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cmbCursoA.Enabled = false;
        }

        void disableButton()
        {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        void enableButton()
        {
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        void enableTextbox()
        {
            txtCarnet.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cmbCursoA.Enabled = true;
        }

        void clearTextbox()
        {
            txtCarnet.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cmbCursoA.SelectedValue = 1;
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clearTextbox();
            opcion = "Guardar";
            enableButton();
            enableTextbox();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(opcion.Equals("Guardar")){

                try
                {

                    cargarAlumno();
                    contexto.Alumno.Add(a);
                    contexto.SaveChanges();

                    if (a.idCa == 1)
                    {
                        contexto.AgregarDetalleNota(a.carnet);
                        contexto.SaveChanges();
                    }

                    else if(a.idCa == 2){
                        contexto.AgregarDetalleNota1(a.carnet);
                        contexto.SaveChanges();
                    }

                    cargarTabla();
                    clearTextbox();

                }

                catch (SqlException ex)
                {

                    MessageBox.Show("Error al guardar el registro: " + ex.Message);

                }

            }

            if (opcion == "Modificar")
            {
                try
                {
                    cargarAlumno();
                    Alumno al = contexto.Alumno.FirstOrDefault(x => x.carnet == a.carnet);
                    al.nombre = txtNombre.Text;
                    al.apellido = txtApellido.Text;
                    al.idCa = int.Parse(cmbCursoA.SelectedValue.ToString());

                    contexto.SaveChanges();
                    cargarTabla();
                    btnNuevo.Enabled = true;
                    clearTextbox();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo un error al modificar: " + ex.Message);
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            opcion = "Modificar";
            enableButton();
            enableTextbox();
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void dgvAlumno_Click(object sender, EventArgs e)
        {
            if (dgvAlumno.SelectedRows.Count != 0)
            {
                txtCarnet.Text = dgvAlumno.SelectedRows[0].Cells[0].Value.ToString();
                txtNombre.Text = dgvAlumno.SelectedRows[0].Cells[1].Value.ToString();
                txtApellido.Text = dgvAlumno.SelectedRows[0].Cells[2].Value.ToString();
                cmbCursoA.SelectedValue = int.Parse(dgvAlumno.SelectedRows[0].Cells[3].Value.ToString());

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumno.SelectedRows.Count != 0)
            {
                try
                {
                    cargarAlumno();
                    if (MessageBox.Show(this, "¿Eliminar registro?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Alumno alumno = contexto.Alumno.FirstOrDefault(x => x.carnet == a.carnet);
                        contexto.Alumno.Remove(alumno);
                        contexto.SaveChanges();
                        cargarTabla();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
                
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            disableButton();
            disableTextbox();
            btnNuevo.Enabled = true;
            clearTextbox();
        }
    }
}
