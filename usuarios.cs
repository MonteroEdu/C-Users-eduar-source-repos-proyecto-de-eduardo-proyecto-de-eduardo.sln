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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        // Botón: Agregar nuevo usuario
        private void button1_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = tusuario.Text.Trim();                 // Obtenemos el nombre de usuario ingresado

            if (string.IsNullOrEmpty(nuevoUsuario))                   // Verificamos si el campo está vacío
            {
                MessageBox.Show("Ingrese un nombre de usuario.");   // Si está vacío, mostramos un mensaje de error
                return;
            }

            // Usamos el método que también genera la contraseña automáticamente
            string contrasena = ClsUsuario.AgregarUsuario(nuevoUsuario);         // Intentamos agregar el usuario y obtener su contraseña

            if (string.IsNullOrEmpty(contrasena))                               // Si la contraseña es vacía, significa que el usuario ya existe
            {
                MessageBox.Show("El usuario ya existe.");                       // Mostramos un mensaje de error
            }
            else
            {
                MessageBox.Show($"El usuario '{nuevoUsuario}' se agregó correctamente y su Contraseña generada en el sistemas es: '{contrasena}' "); 
                tusuario.Clear();            // Limpiamos el campo de texto para ingresar un nuevo usuario
            }
        }

        // Botón: Ver lista de usuarios registrados
        private void button2_Click(object sender, EventArgs e)
        {
            if (ClsUsuario.Listausuarios.Count == 0)                // Verificamos si la lista de usuarios está vacía
            {
                MessageBox.Show("No hay usuarios registrados.");  // Si está vacía, mostramos un mensaje
                return;
            }

            string lista = "Usuarios registrados:\n\n";         // Iniciamos un string para mostrar la lista de usuarios

            foreach (var persona in ClsUsuario.Listausuarios)  // Iteramos sobre cada usuario en la lista
            {
                lista += "- " + persona + "\n";               // Agregamos el usuario a la lista
            }

            MessageBox.Show(lista);                          // Mostramos la lista de usuarios en un mensaje
        }

        // BOTÓN NUEVO: Mostrar usuarios y contraseñas
        private void button3_Click(object sender, EventArgs e)
        {
            if (ClsUsuario.UsuariosContrasenas.Count == 0)        // Verificamos si el diccionario de usuarios y contraseñas está vacío
            {
                MessageBox.Show("No hay usuarios registrados.");  // Si está vacío, mostramos un mensaje
                return;
            }

            string lista = "Usuarios y contraseñas:\n\n";            // Iniciamos un string para mostrar la lista de usuarios y contraseñas

            foreach (var kvp in ClsUsuario.UsuariosContrasenas)      // Iteramos sobre cada par clave-valor en el diccionario
            {
                lista += $"{kvp.Key} - {kvp.Value}\n";               // Agregamos el usuario y su contraseña a la lista
            }

            MessageBox.Show(lista);                                  // Mostramos la lista de usuarios y contraseñas en un mensaje
        }

        private void tusuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
