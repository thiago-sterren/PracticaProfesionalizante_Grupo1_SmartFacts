using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backk
{
    public class Proveedor
    {
        public int cuit_prov { get; set; }
        public string nombre_empresa { get; set; }
        public Proveedor(int cuit_prov, string nombre_empresa)
        {
            this.cuit_prov = cuit_prov;
            this.nombre_empresa = nombre_empresa;
        }
    }
}
