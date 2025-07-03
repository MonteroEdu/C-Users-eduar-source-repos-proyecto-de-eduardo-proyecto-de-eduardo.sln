using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_eduardo
{
    internal class ClsUsuario
    {
        public static string tipo = "";                                   // Guarda el tipo de usuario ("Admin" o "Comprador")

        // Diccionario que relaciona cada usuario con su contraseña
        public static Dictionary<string, string> UsuariosContrasenas = new Dictionary<string, string>();

        // Contador para generar contraseñas automáticas
        private static int contadorUsuarios = 1;

        public static void inicializarLista()
        {
            UsuariosContrasenas.Clear();                                        // Limpia el diccionario de usuarios y contraseñas
            UsuariosContrasenas.Add("Admin", "123");                            //el usuario Admin tiene una contraseña fija "123"
            contadorUsuarios = 1;                                               // Reinicia el contador de usuarios para generar contraseñas automáticas

            Listausuarios.Clear();                                               //Limpia la lista de usuarios
            Listausuarios.Add("Admin");                                          // Agrega el usuario Admin a la lista pública de usuarios
        }
        // Lista pública de nombres de usuario
        public static List<string> Listausuarios = new List<string>();

       
        public static bool validarUsuarioContrasena(string usuario, string contrasena)
        // Método para validar usuario y contraseña
        {
            if (string.IsNullOrEmpty(contrasena))                                     // Verifica si la contraseña está vacía
                return false;                                                        // Si está vacía, retorna false

            string pass;
            if (UsuariosContrasenas.TryGetValue(usuario, out pass)) 
            {
                if (pass == contrasena)                                                  // Si la contraseña coincide
                {
                    // Define el tipo de usuario (admin o comprador)
                    tipo = usuario == "Admin" ? "Admin" : "Comprador";              
                    return true;
                }
            }
            return false;
        }

        public static string AgregarUsuario(string usuario)                              // Agrega un nuevo usuario con una contraseña generada automáticamente

        {
            if (UsuariosContrasenas.ContainsKey(usuario))                               // Verifica si el usuario ya existe en el diccionario
            {
                return "";                                                           // Si el usuario ya está registrado, retorna una cadena vacía
            }

            string nuevaContrasena = contadorUsuarios.ToString("D3");             // Genera una contraseña de 3 dígitos (001, 002, ...)
            UsuariosContrasenas.Add(usuario, nuevaContrasena);                   // Agrega el nuevo usuario y su contraseña al diccionario
            Listausuarios.Add(usuario);                                         // También lo agregamos a la lista pública
            contadorUsuarios++;                                                // Incrementamos el contador para la próxima contraseña
            return nuevaContrasena;
        }
    }
}

