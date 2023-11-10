using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string contrasenia { get; set; }
        public string usuario { get; set; }
        public Cliente(string nombre, string apellido, string contrasenia, string usuario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.contrasenia = contrasenia;
            this.usuario = usuario;
        }
    }
}
