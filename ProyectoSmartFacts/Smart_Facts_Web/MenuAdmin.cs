using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Smart_Facts;

namespace Smart_Facts_Web
{
    public partial class MenuAdmin : Form
    {
        private Principal principal;
        public MenuAdmin(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DisplayMember = "info_list_box";
            listBoxClientes.DataSource = principal.lista_clientes;
        }
    }
}
