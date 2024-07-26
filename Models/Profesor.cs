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

        public int CalcularAntiguedad(){
            return DateTime.Now.Month - FechaContratacion.Month;
        }

        public void ObtenerSalario(){
            Console.WriteLine($"El salario del profesor {Nombre} {Apellido} es: ${Salario}");
        }

    }
}