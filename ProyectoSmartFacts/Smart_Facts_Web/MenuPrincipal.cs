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
    public partial class MenuPrincipal : Form
    {
        private Principal principal;
        public MenuPrincipal()
        {
            InitializeComponent();
            principal = new Principal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevo_cliente = new Cliente(int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, txtContrasenia.Text);
            principal.AltaCliente(nuevo_cliente);
            Catalogo catalogo = new Catalogo();
            catalogo.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            principal.GenerarClientesHardcodeados();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            PantallaInicioSesion inicio_sesion = new PantallaInicioSesion();
            inicio_sesion.Show();
        }
    }
}
