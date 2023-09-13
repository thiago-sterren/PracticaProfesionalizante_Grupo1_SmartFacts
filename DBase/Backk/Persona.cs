using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Persona
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Persona(int DNI, string Nombre, string Apellido)
        {
            this.dni = DNI;
            this.nombre = Nombre;
            this.apellido = Apellido;
        }
    }
}
