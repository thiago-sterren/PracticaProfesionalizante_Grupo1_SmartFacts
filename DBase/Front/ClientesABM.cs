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
    public partial class ClientesABM : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public ClientesABM()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaClientes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuAdm menuadm = new MenuAdm();
            menuadm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtUsuario.Text != "" && txtContrasenia.Text != "")
            {
                Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtContrasenia.Text, txtUsuario.Text);
                principal.AltaCliente(cliente);
                MessageBox.Show("Se ha agregado el cliente con éxito");
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Complete todos los campos, por favor");
            }
        }

        private void ClientesABM_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
                Cliente idCliente = (Cliente)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
                principal.BajaCliente(idCliente);
                MessageBox.Show("Se ha borrado un Cliente");
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Seleccione una celda, por favor");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtUsuario.Text != "" && txtContrasenia.Text != "")
            {
                int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
                Cliente idCliente = (Cliente)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
                if (celdaSeleccionada != null)
                {
                    idCliente.nombre = txtNombre.Text;
                    idCliente.apellido = txtApellido.Text;
                    idCliente.contrasenia = txtContrasenia.Text;
                    idCliente.usuario = txtUsuario.Text;
                    principal.ModificacionCliente(idCliente);
                    MessageBox.Show("Se ha modificado un Cliente");
                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Seleccione una celda, por favor");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos, por favor");
            }
        }
    }
}
