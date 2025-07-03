namespace proyecto_de_eduardo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                    // Inicializa todos los controles del formulario

                                                   // Verifica si el usuario actual NO es administrador
            if (!ClsUsuario.tipo.Equals("Admin"))
                opcionadmin.Enabled = false;     // Si no es admin, desactiva el botón/menú de administración
            else
                opcionadmin.Enabled = true;    // Si es admin, habilita el menú de administración
        }
        public static void Activarmenu()
        {
        }
        private void cargarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {             
        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();               // Crea una instancia del formulario de ventas  
            ventas.ShowDialog();                         // Lo muestra como ventana 
        }
        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios pantallausuarios = new usuarios(); // Crea una instancia del formulario de usuarios
            pantallausuarios.ShowDialog();              // Lo muestra como ventana
        }
    }
}
