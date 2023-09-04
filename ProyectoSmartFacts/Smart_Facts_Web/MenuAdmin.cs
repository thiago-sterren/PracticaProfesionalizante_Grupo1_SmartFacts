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
        public MenuAdmin()
        {
            InitializeComponent();
            principal = new Principal();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            List<Cliente> lista = principal.GenerarClientesHardcodeados();
            foreach (Cliente x in lista)
            {
                principal.lista_clientes.Add(x);
            }
            listBoxClientes.DataSource = null;
            listBoxClientes.DisplayMember = "info_list_box";
            listBoxClientes.DataSource = principal.lista_clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevo_cliente = new Cliente(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            principal.AltaCliente(nuevo_cliente);
            MessageBox.Show("Se ha agregado un nuevo cliente a la lista");
            listBoxClientes.DataSource = null;
            listBoxClientes.DisplayMember = "info_list_box";
            listBoxClientes.DataSource = principal.lista_clientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente_borrado = (Cliente)listBoxClientes.SelectedItem;
            principal.BajaCliente(cliente_borrado);
            MessageBox.Show("Cliente borrado");
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = principal.lista_clientes;
            listBoxClientes.DisplayMember = "info_list_box";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente_reemplazante = new Cliente(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            principal.ModificacionCliente((Cliente)listBoxClientes.SelectedItem, cliente_reemplazante);
            listBoxClientes.DataSource = null;
            listBoxClientes.DisplayMember = "info_list_box";
            listBoxClientes.DataSource = principal.lista_clientes;
        }
    }
}
