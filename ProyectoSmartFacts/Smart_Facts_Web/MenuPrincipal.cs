using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Facts_Web
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContra.Text == "admin")
            {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Hide();
            } else
            {
                Catalogo catalogo = new Catalogo();
                catalogo.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registracion registracion = new Registracion();
            registracion.Show();
            this.Hide();
        }
    }
}
