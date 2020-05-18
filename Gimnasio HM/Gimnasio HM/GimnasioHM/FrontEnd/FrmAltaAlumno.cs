using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendClases;

namespace FrontEnd
{
    public partial class FrmAltaAlumno : Form
    {
        Gimnasio gimnasio;
        public FrmAltaAlumno(Gimnasio gim)
        {
            InitializeComponent();
            gimnasio = gim;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtApellido is null || txtNombre is null || txtDNI is null || txtEdad is null)
            {

                MessageBox.Show("ERROR, Revise que los campos claves esten completos: Nombre, Apellido, Edad y DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Alumno alum = this.AgregarAlumno();
                if (!(alum is null))
                {

                    FrmPrincipal.gimnasio.alumnos.Add(alum);
                }
                else {
                    MessageBox.Show("No se pudo agregar el alumno al gimnasio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Esta seguro que desea regresar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == DialogResult)
            {
                this.Close();
            }


        }

        private Alumno AgregarAlumno()
        {

            bool todoOK = true;
            Alumno alum = null;

            if (txtApellido is null || txtNombre is null || txtDNI is null || txtEdad is null)
            {

                MessageBox.Show("ERROR, Revise que los campos claves esten completos: Nombre, Apellido, Edad y DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    alum = new Alumno(txtNombre.Text, txtApellido.Text, this.DetectarDeporte(), txtTelefono.Text, txtDNI.Text, txtEdad.Text);

                    if (alum is null)
                    {
                        todoOK = false;
                    }

                }
                catch (Exception)
                {
                    todoOK = false;

                }


                if (todoOK)
                {
                    MessageBox.Show("Alumno Creado correctamente", "Alumno Creado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error a la hora de dar de alta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return alum;

        }
        

        private string DetectarDeporte()
        {

            string deporte;

            if (checkBox.Checked)
            {
                deporte = "Boxeo";
            }
            else if (checkFun.Checked)
            {
                deporte = "Funcional";
            }
            else
            {
                deporte = "Taekwondo";
            }

            return deporte;

        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            checkBox.Checked = false;
            checkFun.Checked = false;
            checkTae.Checked = false;

        }
    }
}
