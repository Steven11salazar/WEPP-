using System;
using System.Windows.Forms;

namespace Word_Pantalla_Principal
{
    public partial class frmListaLecciones : Form
    {
        private int Nivel;
        private int Curso;
        public frmListaLecciones(int  CursoEndiado, int NivelEnviado)
        {
             InitializeComponent();
            Nivel = NivelEnviado;
            Curso = CursoEndiado;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                        this.Dispose();
        }

        private void btnLeccion1_1_Click(object sender, EventArgs e)
        {

        }

        private void Word1_Load(object sender, EventArgs e)
        {
            string Encabezado = "Nivel ";
            string Titulo = (Curso == 1 ? "Word" : (Curso == 2 ? "Excel" : "Power Point"));
            if (Nivel == 1)
            {
                Encabezado += " Basico"; // Encabezado = Encabezado + "***"
            }
            else if (Nivel ==2)
            {
                Encabezado += " Medio";
            }
            else
            {
                Encabezado += " Avanzado";
            }
            this.Text = Encabezado;
            lblTituo.Text = "Uso de " + Titulo + Encabezado.Replace("Nivel","");              
               
        }
    }
}
