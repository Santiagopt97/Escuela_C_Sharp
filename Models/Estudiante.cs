using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models
{
    public class Estudiante : Persona
    {
        public string NombreAcudiente { get; set; }
        public string CursoActual { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public List<double> Calificaciones { get; set; }

        public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Email = email;
            Telefono = telefono;
            NombreAcudiente = nombreAcudiente;
            CursoActual = cursoActual;
            FechaNacimiento = fechaNacimiento;
            Calificaciones = new List<double>();
        }

        public override void MostrarDetalles(){
            Console.WriteLine("-------------Detalles del Estudiante-------------------");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Tipo Documento: {TipoDocumento}");
            Console.WriteLine($"Número Documento: {NumeroDocumento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
            Console.WriteLine($"Curso Actual: {CursoActual}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento}");
            Console.WriteLine("Calificaciones:");
            foreach (var calificacion in Calificaciones)
            {
                Console.WriteLine(calificacion);
            }
            Console.WriteLine("-----------------------------------------------------------");
        }

       
        public void AgregarCalificaciones(double calificacion){
            Calificaciones.Add(calificacion);
        }

        public void CalcularPromedio(){
            Console.Write($"El estudiante tiene un promedio de: {Calificaciones.Average()}");
        }

        public int CalcularEdad(){
            return DateTime.Now.Year - FechaNacimiento.Year;
        }

        public string ObtenerNumDocumento(){
           return NumeroDocumento;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }

        public string ObtenerApellido()
        {
            return Apellido;
        }

        public string ObtenerCursoActual()
        {
            return CursoActual;
        }
    }
}