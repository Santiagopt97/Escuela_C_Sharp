using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models
{
    public class Persona
    {
        protected Guid Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string TipoDocumento { get; set; }
        protected string NumeroDocumento { get; set; }
        protected string Email { get; set; }
        protected string Telefono { get; set; }

        public virtual void MostrarDetalles(){
            Console.WriteLine($@"
            Id: {Id} 
            Nombre: {Nombre} Apellido: {Apellido} 
            Tipo de Documento: {TipoDocumento}: Número de Documento: {NumeroDocumento}
            Email: {Email} 
            Teléfono: {Telefono}");
        }
    }
}