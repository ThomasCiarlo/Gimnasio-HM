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
    public partial class FrmListarAlumnos : Form
    {
        Gimnasio gimnasio;
        public FrmListarAlumnos(Gimnasio gim)
        {
            InitializeComponent();
            gimnasio = gim;
            dataAlumnos.DataSource = gim.alumnos;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            foreach (Alumno a in gimnasio.alumnos)
            {
                if (a.DNI == txtDNI.Text) {

                    List<Alumno> alums = new List<Alumno>();
                    alums.Add(a);
                    dataAlumnos.DataSource = alums;
                
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataAlumnos.DataSource = gimnasio.alumnos;
        }
    }
}
