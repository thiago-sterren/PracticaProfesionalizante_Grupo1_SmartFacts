using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Cliente
    {
        public int id { get; set; }
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
        public string info_list_box
        {
            get { return $"{nombre} {apellido}. ID: {id}. Usuario: {usuario}. Contrasenia: {contrasenia}."; }
        }
    }
}
