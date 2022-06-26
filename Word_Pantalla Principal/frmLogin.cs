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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Usuario Requerido");
            }
            else if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Contraseña Requerida");
            }
            else
            {
                this.Hide();
                new frmListadoCursos(1, txtUsuario.Text).Show(); }
            //Verificas si usuario existe
            
        }
    }
}
