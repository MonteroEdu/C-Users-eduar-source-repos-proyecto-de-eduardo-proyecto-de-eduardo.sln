using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_de_eduardo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Obtiene los valores escritos por el usuario
            string usuario = tusuario.Text.Trim();
            string contrasena = tclave.Text.Trim();

            // Verifica si el usuario y contraseña son correctos
            if (ClsUsuario.validarUsuarioContrasena(usuario, contrasena))
            {
                // Si son válidos, abre el formulario principal
                Form1 menuprincipal = new Form1();
                menuprincipal.ShowDialog();
            }
            else
            {
                // Si son incorrectos, muestra mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ClsUsuario.inicializarLista();
        }
    }
}
