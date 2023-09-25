using Backk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front
{
    public partial class Registracion : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public Registracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            Cliente? usuarioEncontrado = context.Clientes.FirstOrDefault(c => c.usuario == usuarioIngresado);
            if (usuarioEncontrado == null)
            {
                Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtContrasenia.Text, txtUsuario.Text);
                principal.AltaCliente(cliente);
                MessageBox.Show("Se ha registrado con éxito");
                Catalogo catalogo = new Catalogo();
                catalogo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El nombre de usuario ya existe, intente con otro");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
