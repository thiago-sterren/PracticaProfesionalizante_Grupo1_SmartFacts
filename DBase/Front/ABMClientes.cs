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
    public partial class ABMClientes : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public ABMClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdm menuadm = new MenuAdm();
            menuadm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(textBox1.Text, textBox2.Text, textBox4.Text, txtUser.Text);
            principal.AltaCliente(cliente);
            MessageBox.Show("Cliente agregado");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = context.Clientes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBox1.SelectedItem;
            principal.BajaCliente(cliente);
            MessageBox.Show("Cliente eliminado");
            listBox1.DataSource = null;
            listBox1.DataSource = context.Clientes;
            listBox1.DisplayMember = "info_list_box";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(textBox1.Text, textBox2.Text, txtUser.Text, textBox4.Text);
            principal.ModificacionCliente((Cliente)listBox1.SelectedItem, cliente);
            MessageBox.Show("Modificación realizada");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = context.Clientes;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = context.Clientes;
        }
    }
}
