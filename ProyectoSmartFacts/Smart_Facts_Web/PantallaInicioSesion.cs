using Clases_Smart_Facts;
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
    public partial class PantallaInicioSesion : Form
    {
        private Principal principal;
        public PantallaInicioSesion()
        {
            InitializeComponent();
            principal = new Principal();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<Cliente> lch = principal.GenerarClientesHardcodeados();
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
            }
            else if ((textBox1.Text == lch[0].nombre && textBox2.Text == lch[0].contrasenia) || (textBox1.Text == lch[1].nombre && textBox2.Text == lch[1].contrasenia) || (textBox1.Text == lch[2].nombre && textBox2.Text == lch[2].contrasenia) || (textBox1.Text == lch[3].nombre && textBox2.Text == lch[3].contrasenia))
            {
                Catalogo catalogo = new Catalogo();
                catalogo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Vuelva a intentarlo");
            }
        }
    }
}
