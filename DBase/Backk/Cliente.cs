using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Backk
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
