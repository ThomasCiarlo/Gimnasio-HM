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
    public partial class FrmCobro : Form
    {
        private Gimnasio gimnasio;
        private Alumno alumno;
        public FrmCobro(Gimnasio gim)
        {
            InitializeComponent();
            gimnasio = gim;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            foreach (Alumno a in gimnasio.alumnos)
            {
                if (a.DNI == txtDNI.Text)
                {

                    txtNombre.Text = a.Nombre;
                    txtApellido.Text = a.Apellido;
                    txtDeporte.Text = a.Deporte;
                    txDni.Text = a.DNI;

                    alumno = a;

                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            bool todoOK = true;

            try
            {

                if (radioBoxeo.Checked)
                {

                    alumno.AlumnoPago("Boxeo", Convert.ToInt32(txtImporte.Text), ObtenerPase());
                    AgregarPago(alumno);

                }
                else if (radioFuncional.Checked)
                {

                    alumno.AlumnoPago("Funcional", Convert.ToInt32(txtImporte.Text), ObtenerPase());
                    AgregarPago(alumno);
                }
                else
                {

                    alumno.AlumnoPago("Taekwondo", Convert.ToInt32(txtImporte.Text), ObtenerPase());
                    AgregarPago(alumno);
                }
            }
            catch (Exception) {

                todoOK = false;
            
            }

            if (todoOK)
            {

                MessageBox.Show("Se cargo el pago correctamente");

            }
            else {
                MessageBox.Show("Se Produjo un error");
            }



        }

        private string ObtenerPase()
        {

            string pase;

            if (radio2Dias.Checked)
            {

                pase = "Dos Dias";

            }
            else
            {

                pase = "Cuatro Dias";
            }

            return pase;

        }

        private void AgregarPago(Alumno a) {

            foreach (Alumno alumno in FrmPrincipal.gimnasio.alumnos) 
            {
                if (a.DNI == alumno.DNI) {

                    a.UltimaCuotaMostrar();
                    alumno.StringCuota = a.StringCuota;
                
                }
            }
        
        
        }

    }
}
