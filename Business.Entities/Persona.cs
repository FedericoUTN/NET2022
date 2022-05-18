using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        public Persona()
        {
            this.TipoPersona = TiposPersonas.Alumno;
        }
        public string? Apellido { get; set; }
        public string? Nombre { get; set;}

        public string? Email { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public int IDPlan { get; set; }
        public int Legajo { get; set; }
        public string? Telefono { get; set; }
        public TiposPersonas TipoPersona { get; set; }

        public enum TiposPersonas
        {
            Alumno,
            Docente,
            Administrador
        }
    }
}
