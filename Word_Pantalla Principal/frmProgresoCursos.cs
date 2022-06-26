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
    public partial class frmProgresoCursos : Form
    {
        public frmProgresoCursos()
        {
            InitializeComponent();
        }

        private void frmProgresoCursos_Load(object sender, EventArgs e)
        {
            label1.Text = "Word";
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 35;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmProgresoCursos_Load_1(object sender, EventArgs e)
        {
            label1.Text = "Word";
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 35;
            progressBar1.ForeColor = Color.Blue;

            label6.Text = "Publich";
            progressBar6.Maximum = 100;
            progressBar6.Minimum = 0;
            progressBar6.Value = 25;
            progressBar6.BackColor = Color.DarkGreen;

            label5.Text = "One Drive";
            progressBar5.Maximum = 100;
            progressBar5.Minimum = 0;
            progressBar5.Value = 60;
            progressBar5.BackColor = Color.DeepSkyBlue;

            label4.Text = "Proyect";
            progressBar4.Maximum = 100;
            progressBar4.Minimum = 0;
            progressBar4.Value = 70;
            progressBar4.BackColor = Color.ForestGreen;

            label3.Text = "Power Point";
            progressBar3.Maximum = 100;
            progressBar3.Minimum = 0;
            progressBar3.Value = 100;

            progressBar3.BackColor = Color.Orange;
            label2.Text = "Word";

            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;
            progressBar2.Value = 10;
            progressBar2.BackColor = Color.Green;

        }
    }
}
