using GymManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace GymManagement.Controllers
{
    public class UsuariosController
    {
        private List<Usuario> _usuarios;

        public UsuariosController()
        {
            _usuarios = LoadInitialUsers();
        }

        // Método para cargar usuarios segun entendi pero mejor vemos la clase de nuevo
        private List<Usuario> LoadInitialUsers()
        {
            // Datos de ejemplo porque tenemos que cargarlos como dijo el profe
            return new List<Usuario>
            {
                new Usuario(1, "Yostin Luna", UserType.Cliente, new List<string> { "Lunes 9:00-10:00", "Miércoles 11:00-12:00" }, new List<string>()),
                new Usuario(2, "Daniela Boza", UserType.Cliente, new List<string> { "Martes 10:00-11:00", "Jueves 12:00-13:00" }, new List<string>()),
                new Usuario(3, "Luis Monge", UserType.Entrenador, new List<string> { "Lunes 9:00-12:00", "Viernes 10:00-13:00" }, new List<string> { "Cardio", "Pesas" }),
                new Usuario(4, "Akane Santamaría", UserType.Entrenador, new List<string> { "Miércoles 8:00-10:00", "Sábado 11:00-13:00" }, new List<string> { "Zumba", "Yoga" }),
                new Usuario(5, "Greivin Mejia", UserType.Cliente, new List<string> { "Lunes 14:00-15:00", "Viernes 9:00-10:00" }, new List<string>()),
                new Usuario(6, "Nicole Hernandez", UserType.Entrenador, new List<string> { "Martes 9:00-12:00", "Jueves 15:00-18:00" }, new List<string> { "Funcional", "CrossFit" }),
                new Usuario(7, "Angelo Wong", UserType.Administrador, new List<string> { "Lunes a Miércoles 6:00-12:00", "Miercoles a Viernes 12:00-18:00" }, new List<string> { "Permisos", "Planilla" }),
                new Usuario(8, "Christopher Calvo", UserType.Administrador, new List<string> { "Lunes a Miércoles 12:00-18:00", "Miercoles a Viernes 6:00-12:00" }, new List<string> { "Control de Equipo", "Admision de Clientes" })
            };
        }

        // Obtener todos los usuarios
        public List<Usuario> GetAllUsers()
        {
            return _usuarios;
        }

        // Separamos los usuarios por tipo si son Cliente o Entrenador
        public List<Usuario> GetUsersByType(UserType userType)
        {
            return _usuarios.Where(u => u.Tipo == userType).ToList();
        }

        // Agregar un nuevo usuario al sistema.
        public void AddUser(Usuario newUser)
        {
            _usuarios.Add(newUser);
        }

        // Buscar un usuario por ID.
        public Usuario GetUserById(int id)
        {
            return _usuarios.FirstOrDefault(u => u.Id == id);
        }
    }
}
