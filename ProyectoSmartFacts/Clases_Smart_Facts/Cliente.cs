using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Smart_Facts
{
    public class Cliente : Persona
    {
        public string contrasenia { get; set; }
        public Cliente(int DNI, string Nombre, string Apellido, string Contrasenia) : base(DNI, Nombre, Apellido)
        {
            this.contrasenia = Contrasenia;
        }
        public string info_list_box
        {
            get { return $"{nombre} {apellido}. DNI: {dni}. Contrasenia: {contrasenia}."; }
        }
    }
}
