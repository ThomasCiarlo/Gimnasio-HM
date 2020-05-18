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
    public partial class FrmPrincipal : Form
    {
        public static Gimnasio gimnasio;

        public FrmPrincipal()
        {
            InitializeComponent();
            gimnasio = new Gimnasio();
            Alumno thomas = new Alumno("thomas", "ciarlo", "Boxeo", "112245654", "2531526246", "21");
            Alumno Eve = new Alumno("eve", "ibarra", "Funcional", "1123242245654", "13324414", "21");
            thomas.AlumnoPago("Funcional", 700,"dos dias" );
            Eve.AlumnoPago("Boxeo", 700, "dos dias");


            gimnasio.alumnos.Add(thomas);
            gimnasio.alumnos.Add(Eve);
        }


        private void btnAlumnos_Click(object sender, EventArgs e)
        {

            AddFormInPanel(new FrmAltaAlumno(gimnasio));

        }

        #region Funciones
        private void AddFormInPanel(object formHijo)
        {
            if (this.PanelPadre.Controls.Count > 0)
                this.PanelPadre.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelPadre.Controls.Add(fh);
            this.PanelPadre.Tag = fh;
            fh.Show();
        }


        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmOpcionesDeVistas());
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmCobro(gimnasio));
        }

        private void PanelPadre_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
