using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Pantalla_Principal
{
    public partial class frmListadoCursos : Form
    {
        /*
         * Cursos:
         * 1- Word
         * 2- Excel
         * 3- Power
         * */
        public frmListadoCursos(int idUsuario, string Nombre)
        {
            InitializeComponent();
        }

        private void frmListadoLecciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmListaNiveles(1).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmListaNiveles(2).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmListaNiveles(3).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmProgresoCursos().Show();
        }
    }
}
