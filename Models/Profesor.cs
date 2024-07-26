using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models
{
    public class Profesor : Persona 
    {
        public string Asignatura { get; set; }
        public double Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        public List<string> Cursos { get; set; }

        public Profesor(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string asignatura, double salario, DateTime fechaContratacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Email = email;
            Telefono = telefono;
            Asignatura = asignatura;
            Salario = salario;
            FechaContratacion = fechaContratacion;
            Cursos = new List<string>();
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("Detalles del profesor");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Profesor: {Nombre} {Apellido}");
             Console.WriteLine($"Tipo Documento: {TipoDocumento}");
            Console.WriteLine($"Número Documento: {NumeroDocumento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Asignatura: {Asignatura}");
            Console.WriteLine($"Salario: ${Salario}");
            Console.WriteLine($"Fecha de contratación: {FechaContratacion.ToShortDateString()}");
            Console.WriteLine("Cursos impartidos:");
            foreach (var curso in Cursos)
            {
                Console.WriteLine(curso);
            }
        }

        public int CalcularAntiguedad(){
            return DateTime.Now.Month - FechaContratacion.Month;
        }

        public void ObtenerSalario(){
            Console.WriteLine($"El salario del profesor {Nombre} {Apellido} es: ${Salario}");
        }

    }
}