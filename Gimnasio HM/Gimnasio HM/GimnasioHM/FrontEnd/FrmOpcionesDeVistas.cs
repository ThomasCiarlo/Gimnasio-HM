using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class FrmOpcionesDeVistas : Form
    {

        public FrmOpcionesDeVistas()
        {
            InitializeComponent();
        }

        private void FrmOpcionesDeVistas_Load(object sender, EventArgs e)
        {

        }

        private void AddFormInPanel(object formHijo)
        {
            

            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmListarAlumnos(FrmPrincipal.gimnasio));
        }
    }
}
