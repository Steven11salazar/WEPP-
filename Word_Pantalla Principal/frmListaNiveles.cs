using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Word_Pantalla_Principal.Program;

namespace Word_Pantalla_Principal
{
    public partial class frmListaNiveles : Form
    {
        /*
         Niveles: 
        1- Basco
        2- Intermedio
        3- Avanzado
         */
        private int Cursos;
        public frmListaNiveles(int Curso)
        {
            InitializeComponent();
            Cursos = Curso;
        }



        private void btnBasico_Click(object sender, EventArgs e)
        {
            new frmListaLecciones( Cursos, 1).ShowDialog();
           // this.Hide();
        }//Fin de la clase

        private void btnMedio_Click(object sender, EventArgs e)
        {
            new frmListaLecciones(Cursos,2).ShowDialog();

        }

        private void btnAvanzado_Click(object sender, EventArgs e)
        {
            new frmListaLecciones( Cursos, 3).ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbSalida_Click(object sender, EventArgs e)
        {
         //  new frmListaLecciones (2).ShowDialog();//Boton de retroceso a la pantalla de cursos.Colocar new pantalla de cursos.
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string Encabezado = (Cursos == 1 ? "Word" : (Cursos == 2 ? "Excel" : "Power Point"));
            lblTitulo.Text = "Uso de " + Encabezado;
            CuadroEncabezado.BackColor = (Cursos == 1 ? Color.Blue : (Cursos == 2 ? Color.Olive : Color.Orange));
            CuadroPie.BackColor = CuadroEncabezado.BackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Ajustes().ShowDialog();
        }
    }//Fin del programa
}
