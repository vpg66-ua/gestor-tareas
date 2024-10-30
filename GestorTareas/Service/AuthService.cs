using GestorTareas.Models;

namespace GestorTareas.Services
{
    public class AuthService
    {
        // Aquí iría la lógica para interactuar con la base de datos
        public bool Register(User user)
        {
            // Lógica para registrar al usuario (agregarlo a la base de datos)
            // Implementa la validación y almacenamiento adecuado aquí.
            return true; // Retorna verdadero si el registro fue exitoso
        }

        public bool Login(string username, string password)
        {
            // Lógica para autenticar al usuario
            // Verifica las credenciales en la base de datos.
            return true; // Retorna verdadero si las credenciales son correctas
        }
    }
}