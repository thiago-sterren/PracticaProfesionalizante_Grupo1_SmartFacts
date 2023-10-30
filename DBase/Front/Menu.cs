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

namespace Front
{
    public partial class Menu : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = textBox1.Text;
            string contraseniaIngresada = textBox2.Text;
            Cliente? clienteEncontrado = context.Clientes.FirstOrDefault(c => c.usuario == usuarioIngresado);
            if (clienteEncontrado != null)
            {
                if (contraseniaIngresada == clienteEncontrado.contrasenia)
                {
                    ClienteActual.cliente_actual = clienteEncontrado;
                    Catalogo catalogo = new Catalogo();
                    catalogo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, intente nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos, intente nuevamente");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registracion registracion = new Registracion();
            registracion.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InicioSesionAdm isadm = new InicioSesionAdm();
            isadm.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
