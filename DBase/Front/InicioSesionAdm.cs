using Backk;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
    public partial class InicioSesionAdm : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public InicioSesionAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userIngresado = textBox1.Text;
            string passIngresada = textBox2.Text;
            Administrador? admEncontrado = context.Admins.FirstOrDefault(a => a.usuario == userIngresado);
            if (admEncontrado != null)
            {
                if (passIngresada == admEncontrado.contrasenia)
                {
                    MenuAdm menuadm = new MenuAdm();
                    menuadm.Show();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
