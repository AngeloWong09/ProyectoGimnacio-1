using System;
using System.Collections.Generic;

namespace GymManagement.Models
{
    public enum UserType
    {
        Cliente,
        Entrenador,
        Administrador
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public UserType Tipo { get; set; }
        public List<string> Horarios { get; set; } = new List<string>();
        public List<string> PuntosFuertes { get; set; } = new List<string>();

        public Usuario(int id, string nombre, UserType tipo, List<string> horarios, List<string> puntosFuertes)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Horarios = horarios;
            PuntosFuertes = puntosFuertes;
        }
    }
}//Hola
