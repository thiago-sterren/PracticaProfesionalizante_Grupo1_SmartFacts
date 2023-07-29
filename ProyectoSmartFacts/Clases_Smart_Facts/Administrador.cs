using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Smart_Facts
{
    public class Administrador : Persona
    {
        public double saldo { get; set; }
        public Administrador(int DNI, string Nombre, string Apellido, double Saldo) : base(DNI, Nombre, Apellido)
        {
            this.saldo = Saldo;
        }
    }
}
