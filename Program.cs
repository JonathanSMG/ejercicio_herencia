
namespace ejercicio_manana.Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Empleados empleados = new Empleados("Bar de comida", 2022, "Pepe", "Aguilar", 1, "Soltero");
            empleados.imprimir();
            Estudiantes estudiante = new Estudiantes("A340", "Pablo", "Espinalezs", 2, "Soltero");
            estudiante.imprimir();
            Personal personal = new Personal("Secretaria", "Diana", "Lopez", 3, "Casada");
            personal.imprimir();
            Profesores profesores = new Profesores("Arquitectura", "Joaquin", "Gonzales", 3, "viudo");
            profesores.imprimir();
        }
    }
    }