using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models
{
    public class AdministradorApp
    {
        public static List<Estudiante> Estudiantes = new List<Estudiante>();
        public static List<Profesor> Profesores = new List<Profesor>();

        
        public static void AgregarEstudiante(Estudiante estudiant)
        {
            Estudiantes.Add(estudiant);
        }

        public static void MostrarEstudiantes()
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDetalles();
            }
        }

        public static void Menu()
        {
            Console.WriteLine("Bienvenido al administrador de la escuela, que deseas hacer el dia de hoy?: ");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Agregar profesor");
            Console.WriteLine("3. Mostrar estudiantes");
            Console.WriteLine("4. Mostrar profesores");
            Console.WriteLine("0. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el nombre del estudiante: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el apellido del estudiante: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingresa el Tipo de Documento del estudiante: ");
                    string tipoDocumento = Console.ReadLine();
                    Console.WriteLine("Ingresa el numero de documento del estudiante: ");
                    string numeroDocumento = Console.ReadLine();
                    Console.WriteLine("Ingresa el correo del estudiante: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Ingresa el telefono del estudiante: ");
                    string telefono = Console.ReadLine();
                    Console.WriteLine("Ingresa el nombre del acudiente del estudiante: ");
                    string nombreAcudiente = Console.ReadLine();
                    Console.WriteLine("Ingresa el curso del estudiante: ");
                    string curso = Console.ReadLine();
                    Console.WriteLine("Ingresa la fecha de nacimiento del estudiante: ");
                    DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    DateOnly fechaNacimiento1 = DateOnly.FromDateTime(fechaNacimiento);

                    Estudiante estudiant = new Estudiante(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, nombreAcudiente, curso, fechaNacimiento1);

                    AgregarEstudiante(estudiant);
                    Console.WriteLine($"El estudiante tiene: {estudiant.CalcularEdad()} años");
                    //El for lo estoy usando para tomar de referencia la misma cantidad de calificaciones para todos los estudiantes.
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Ingresa la calificacion: ");
                        double calificacion = Convert.ToDouble(Console.ReadLine());
                        estudiant.AgregarCalificaciones(calificacion);

                    }
                    estudiant.CalcularPromedio();
                    break;
                case 2:
                    Console.WriteLine("Ingresa el nombre del profesor: ");
                    string nombreProfesor = Console.ReadLine();
                    Console.WriteLine("Ingresa el apellido del profesor: ");
                    string apellidoProfesor = Console.ReadLine();
                    Console.WriteLine("Ingresa el Tipo de Documento del profesor: ");
                    string tipoDocumentoProfesor = Console.ReadLine();
                    Console.WriteLine("Ingresa el numero de documento del profesor: ");
                    string numeroDocumentoProfesor = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Estudiantes registrados:");
                    MostrarEstudiantes();
                    break;
            }
        }

    }
}