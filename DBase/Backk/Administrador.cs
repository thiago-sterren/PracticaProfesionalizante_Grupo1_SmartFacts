using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Administrador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public double salario { get; set; }
        public Administrador(int id, string? nombre, string? apellido, string? usuario, string? contrasenia, double salario)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.salario = salario;
        }
    }
}
