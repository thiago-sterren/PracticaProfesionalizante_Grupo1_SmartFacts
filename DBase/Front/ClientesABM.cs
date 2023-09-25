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
    public partial class ClientesABM : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public ClientesABM()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuAdm menuadm = new MenuAdm();
            menuadm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtContrasenia.Text, txtUsuario.Text);
            principal.AltaCliente(cliente);
            MessageBox.Show("Se ha agregado el cliente con éxito");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
        }

        private void ClientesABM_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.BajaCliente((Cliente)listBox1.SelectedItem);
            MessageBox.Show("Se ha eliminado el cliente con éxito");
            listBox1.DataSource = null;
            listBox1.DataSource = principal.DevolverListaClientes();
            listBox1.DisplayMember = "info_list_box";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente_remove = (Cliente)listBox1.SelectedItem;
            Cliente cliente_add = new Cliente(txtNombre.Text, txtApellido.Text, txtContrasenia.Text, txtUsuario.Text);
            principal.ModificacionCliente(cliente_remove, cliente_add);
            MessageBox.Show("Se ha modificado el cliente con éxito");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
        }
    }
}
