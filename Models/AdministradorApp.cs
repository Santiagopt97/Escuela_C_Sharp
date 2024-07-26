using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Escuela.Models
{
    public class AdministradorApp
    {
        public static List<Estudiante> Estudiantes = new List<Estudiante>();
        public static List<Profesor> Profesores = new List<Profesor>();


        public static void EstudiantesEj()
        {
            var estudiante1 = new Estudiante("Juan", "Pérez", "CC", "12345678", "juan.perez@example.com", "555-1234", "María Pérez", "10A", new DateOnly(2006, 5, 12));
            var estudiante2 = new Estudiante("Ana", "Gómez", "CC", "87654321", "ana.gomez@example.com", "555-4321", "María", "11B", new DateOnly(2005, 3, 21));
            var estudiante3 = new Estudiante("Carlos", "Martínez", "CC", "12348765", "carlos.martinez@example.com", "555-5678", "Laura", "12C", new DateOnly(2004, 8, 15));
            var estudiante4 = new Estudiante("Lucía", "Martínez", "TI", "44332211", "lucia.martinez@example.com", "555-6543", "Pedro", "8A", new DateOnly(2008, 11, 5));
            var estudiante5 = new Estudiante("Pedro", "López", "CC", "99887766", "pedro.lopez@example.com", "555-3210", "María", "10B", new DateOnly(2006, 1, 30));

            Estudiantes.Add(estudiante1);
            Estudiantes.Add(estudiante2);
            Estudiantes.Add(estudiante3);
            Estudiantes.Add(estudiante4);
            Estudiantes.Add(estudiante5);

            estudiante1.AgregarCalificaciones(100);
            estudiante1.AgregarCalificaciones(80);
            estudiante1.AgregarCalificaciones(90);
            estudiante1.AgregarCalificaciones(75);
            estudiante1.AgregarCalificaciones(100);
            estudiante2.AgregarCalificaciones(95);
            estudiante2.AgregarCalificaciones(80);
            estudiante2.AgregarCalificaciones(60);
            estudiante2.AgregarCalificaciones(65);
            estudiante2.AgregarCalificaciones(90);
            estudiante3.AgregarCalificaciones(25);
            estudiante3.AgregarCalificaciones(50);
            estudiante3.AgregarCalificaciones(30);
            estudiante3.AgregarCalificaciones(65);
            estudiante3.AgregarCalificaciones(80);
            estudiante4.AgregarCalificaciones(45);
            estudiante4.AgregarCalificaciones(80);
            estudiante4.AgregarCalificaciones(65);
            estudiante4.AgregarCalificaciones(65);
            estudiante4.AgregarCalificaciones(10);
            estudiante5.AgregarCalificaciones(95);
            estudiante5.AgregarCalificaciones(20);
            estudiante5.AgregarCalificaciones(60);
            estudiante5.AgregarCalificaciones(35);
            estudiante5.AgregarCalificaciones(90);
        }

        public static void ProfesoresEj()
        {
            var profesor1 = new Profesor("Laura", "González", "CC", "123456789", "laura.gonzalez@example.com", "555-1111", "Matemáticas", 8000000, new DateTime(2000, 9, 1));
            var profesor2 = new Profesor("Jorge", "Martínez", "TI", "987654321", "jorge.martinez@example.com", "555-2222", "Historia", 8200000, new DateTime(2016, 3, 15));
            var profesor3 = new Profesor("Ana", "Rodríguez", "CC", "456123789", "ana.rodriguez@example.com", "555-3333", "Biología", 8500000, new DateTime(2017, 1, 10));

            Profesores.Add(profesor1);
            Profesores.Add(profesor2);
            Profesores.Add(profesor3);

            profesor1.AgregarCurso("primero");
            profesor1.AgregarCurso("Segundo");
            profesor2.AgregarCurso("sexto");
            profesor2.AgregarCurso("septimo");
            profesor3.AgregarCurso("octavo");
            profesor3.AgregarCurso("noveno");



        }

        public static void AgregarEstudiante()
        {
            Console.WriteLine("Ingresa el nombre del estudiante: ");
            string? nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido del estudiante: ");
            string? apellido = Console.ReadLine();
            Console.WriteLine("Ingresa el Tipo de Documento del estudiante: ");
            string? tipoDocumento = Console.ReadLine();
            Console.WriteLine("Ingresa el número de documento del estudiante: ");
            string? numeroDocumento = Console.ReadLine();
            Console.WriteLine("Ingresa el correo del estudiante: ");
            string? email = Console.ReadLine();
            Console.WriteLine("Ingresa el teléfono del estudiante: ");
            string? telefono = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre del acudiente del estudiante: ");
            string? nombreAcudiente = Console.ReadLine();
            Console.WriteLine("Ingresa el curso del estudiante: ");
            string? curso = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de nacimiento del estudiante (formato YYYY-MM-DD): ");
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            DateOnly fechaNacimiento1 = DateOnly.FromDateTime(fechaNacimiento);

            Estudiante estudiante = new Estudiante(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, nombreAcudiente, curso, fechaNacimiento1);
            Estudiantes.Add(estudiante);

            Console.WriteLine($"El estudiante tiene: {estudiante.CalcularEdad()} años");

            // Añadir calificaciones, lo uso con i<5 ya que todos los estudiantes deben tener la misma cantidad de notas
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa la calificación: ");
                double calificacion = Convert.ToDouble(Console.ReadLine());
                estudiante.AgregarCalificaciones(calificacion);
            }
            estudiante.CalcularPromedio();
            Console.WriteLine();
        }

        public static void AgregarProfesor()
        {
            Console.WriteLine("Ingresa el nombre del profesor: ");
            string? nombreProfesor = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido del profesor: ");
            string? apellidoProfesor = Console.ReadLine();
            Console.WriteLine("Ingresa el Tipo de Documento del profesor: ");
            string? tipoDocumentoProfesor = Console.ReadLine();
            Console.WriteLine("Ingresa el número de documento del profesor: ");
            string? numeroDocumentoProfesor = Console.ReadLine();
            Console.WriteLine("Ingresa el correo del profesor: ");
            string? emailProfesor = Console.ReadLine();
            Console.WriteLine("Ingresa el teléfono del profesor: ");
            string? telefonoProfesor = Console.ReadLine();
            Console.WriteLine("Ingresa la asignatura del profesor: ");
            string? asignatura = Console.ReadLine();
            Console.WriteLine("Ingresa el salario del profesor: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la fecha de contratación del profesor (formato YYYY-MM-DD): ");
            DateTime fechaContratacion = Convert.ToDateTime(Console.ReadLine());

            Profesor profesor = new Profesor(nombreProfesor, apellidoProfesor, tipoDocumentoProfesor, numeroDocumentoProfesor, emailProfesor, telefonoProfesor, asignatura, salario, fechaContratacion);
            Profesores.Add(profesor);

            Console.WriteLine($"El profesor lleva: {profesor.CalcularAntiguedad()} meses trabajando");
            Console.WriteLine("Cuantos cursos tiene el profesor: ");
            int cursos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cursos; i++)
            {
                Console.WriteLine("Ingresa el nombre del curso: ");
                var curso = Console.ReadLine();
                profesor.AgregarCurso(curso);
            }
        }

        public static void MostrarEstudiantes()
        {
            Console.WriteLine("Estudiantes registrados:");
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDetalles();
                estudiante.CalcularPromedio();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void MostrarProfesores()
        {
            Console.WriteLine("Profesores registrados:");
            foreach (var profesor in Profesores)
            {
                profesor.MostrarDetalles();
            }
        }

        public static Estudiante BuscarEstudiante()
        {
            Console.WriteLine("Ingresa el número de documento del estudiante: ");
            var numDocumento = Console.ReadLine();
            return Estudiantes.Find(estudiante => estudiante.ObtenerNumDocumento() == numDocumento);
        }

        public static Profesor BuscarProfesor()
        {
            Console.WriteLine("Ingresa el número de documento del profesor: ");
            var numDocumento = Console.ReadLine();
            return Profesores.Find(profesor => profesor.ObtenerNumDocumento() == numDocumento);
        }

        public static void EliminarEstudiante(Estudiante estudiante)
        {
            Console.WriteLine($"¿Está seguro de eliminar al estudiante {estudiante.ObtenerNombre()} {estudiante.ObtenerApellido()}?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Estudiantes.Remove(estudiante);
                Console.WriteLine("Estudiante eliminado correctamente!");
            }
            else
            {
                return;
            }
        }

        public static void EliminarProfesor(Profesor profesor)
        {
            Console.WriteLine($"¿Está seguro de eliminar al profesor {profesor.ObtenerNombre()} {profesor.ObtenerApellido()}?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Profesores.Remove(profesor);
                Console.WriteLine("Profesor eliminado correctamente!");
            }
            else
            {
                return;
            }
        }


        public static void Menu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(@"|   Bienvenido al administrador de la escuela     |
|         ¿Qué deseas hacer el día de hoy?           |");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Agregar profesor");
                Console.WriteLine("3. Mostrar estudiantes");
                Console.WriteLine("4. Mostrar profesores");
                Console.WriteLine("5. Eliminar estudiante");
                Console.WriteLine("6. Eliminar profesor");
                Console.WriteLine("7. Editar estudiante");
                Console.WriteLine("8. Editar profesor");
                Console.WriteLine("9. Menu LinQ");
                Console.WriteLine("0. Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarEstudiante();
                        break;
                    case 2:
                        AgregarProfesor();
                        break;
                    case 3:
                        MostrarEstudiantes();
                        break;
                    case 4:
                        MostrarProfesores();
                        break;
                    case 5:
                        EliminarEstudiante(BuscarEstudiante());
                        break;
                    case 6:
                        EliminarProfesor(BuscarProfesor());
                        break;
                    case 7:
                        // EditarEstudiante(BuscarEstudiante());
                        break;
                    case 8:
                        // EditarProfesor(BuscarProfesor());
                        break;
                    case 9:
                        MenuLinq(Estudiantes, Profesores);
                        break;
                    case 0:
                        Console.WriteLine("Gracias por utilizar el administrador de la escuela!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }

        public static void MenuLinq(List<Estudiante> estudiante, List<Profesor> profesor)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine(@"|                       Bienvenido al menu LINQ                                 |");
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("      1. Mostrar estudiantes con promedio superior a 80");
                Console.WriteLine("      2. Obtener la lista de profesores que enseñan más de un curso.");
                Console.WriteLine("      3. Filtrar la lista de estudiantes para obtener solo aquellos cuya edad sea mayor a 16 años");
                Console.WriteLine("      4. Obtener la lista de estudiantes ordenada por apellido en orden ascendente.");
                Console.WriteLine("      5. Calcular el salario total de todos los profesores");
                Console.WriteLine("      6. Encontrar el estudiante con la calificación más alta en su curso actual.");
                Console.WriteLine("      7. Determinar el número de estudiantes en cada curso.");
                Console.WriteLine("      8. Filtrar los profesores que tienen más de 10 años de antigüedad en la institución");
                Console.WriteLine("      9. Obtener la lista de asignaturas únicas que se imparten en la escuela.");
                Console.WriteLine("      10. Encontrar todos los estudiantes cuyo nombre de acudiente sea 'María'.");
                Console.WriteLine("      11. Ordenar la lista de profesores por salario en orden descendente.");
                Console.WriteLine("      12. Calcular el promedio de edad de los estudiantes.");
                Console.WriteLine("      13. Encontrar los profesores que enseñan 'Matemáticas'.");
                Console.WriteLine("      14. Obtener la lista de estudiantes que tienen más de tres calificaciones registradas");
                Console.WriteLine("      15. Calcular la antigüedad promedio de todos los profesores.");
                Console.WriteLine("      0. Volver al menú principal");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        var promedioMayor85 = Estudiantes.Where(estudiante => estudiante.Calificaciones.Average() > 85).ToList();
                        Console.WriteLine("Estudiantes con promedio superior a 85:");
                        foreach (var estudiant in promedioMayor85)
                        {
                            estudiant.MostrarDetalles();
                            estudiant.CalcularPromedio();
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        var profesoresMasDeUnCurso = Profesores.Where(profesor => profesor.Cursos.Count > 1).ToList();
                        Console.WriteLine("Profesores que enseñan más de un curso:");
                        foreach (var profe in profesoresMasDeUnCurso)
                        {
                            profe.MostrarDetalles();
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        var estudiantesMayoresDe16 = estudiante.Where(estudiante => estudiante.CalcularEdad() > 16).ToList();
                        Console.WriteLine("Estudiantes mayores de 16 años:");
                        foreach (var estudiant in estudiantesMayoresDe16)
                        {
                            estudiant.MostrarDetalles();
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        var estudiantesOrdenadosPorApellido = estudiante.OrderBy(estudiante => estudiante.ObtenerApellido()).ToList();
                        Console.WriteLine("Estudiantes ordenados por apellido en orden ascendente:");
                        foreach (var estudiant in estudiantesOrdenadosPorApellido)
                        {
                            estudiant.MostrarDetalles();
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        var salarioTotalProfesores = Profesores.Sum(profesor => profesor.Salario);
                        Console.WriteLine($"El salario total de todos los profesores es: {salarioTotalProfesores:c}");
                        break;
                    case 6:

                        break;
                    case 7:
                        break;
                    case 8:
                    var profeMas5Años = profesor.Where(profesor => profesor.CalcularAntiguedad()/12 > 10).ToList();
                    Console.WriteLine("Profesores que tienen más de 10 años de antigüedad en la institución:");
                    foreach (var profe in profeMas5Años)
                        {
                            profe.MostrarDetalles();
                            Console.WriteLine();
                        }
                        break;
                    case 9:
                        break;
                    case 10:
                        var acudiente = Estudiantes.Where(estudiante => estudiante.NombreAcudiente == "María").ToList();
                        Console.WriteLine("Estudiantes cuyo nombre de acudiente sea 'María':");
                        foreach (var estudiant in acudiente)
                        {
                            estudiant.MostrarDetalles();
                            Console.WriteLine();
                        }
                        break;
                    case 11:
                        var profesoresOrdenadosPorSalario = Profesores.OrderByDescending(profesor => profesor.Salario).ToList();
                        Console.WriteLine("Profesores ordenados por salario en orden descendente:");
                        foreach (var profe in profesoresOrdenadosPorSalario)
                        {
                            profe.MostrarDetalles();
                            Console.WriteLine();
                        }
                        break;
                    case 12:
                        var promedioEdadEstudiantes = estudiante.Average(estudiante => estudiante.CalcularEdad());
                        Console.WriteLine($"El promedio de edad de los estudiantes es: {promedioEdadEstudiantes} años");
                        break;
                    case 13:
                        var pofeMate = profesor.Where(profe => profe.Asignatura == "Matemáticas").ToList();
                        Console.WriteLine("Profesores que enseñan 'Matemáticas':");
                        foreach (var profe in pofeMate)
                        {
                            profe.MostrarDetalles();
                            Console.WriteLine();
                        }
                        break;
                    case 14:
                        var estudiantesConMasDeTresCalificaciones = estudiante.Where(estudiante => estudiante.Calificaciones.Count() > 3).ToList();
                        Console.WriteLine("Estudiantes que tienen más de tres calificaciones registradas:");
                        foreach (var estudiant in estudiantesConMasDeTresCalificaciones)
                        {
                            estudiant.MostrarDetalles();
                            Console.WriteLine();
                        }
                        break;
                    case 15:
                    var antiguedadPromedioProfesores = Profesores.Average(profesor => profesor.CalcularAntiguedad()/12);
                    Console.WriteLine($"El antigüedad promedio de todos los profesores es: {antiguedadPromedioProfesores} años");
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }

    }
}