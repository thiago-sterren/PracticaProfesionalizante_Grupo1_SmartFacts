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
    public partial class ABMCelusNuevos : Form
    {
        Principal principal = new Principal();
        /*private void ActualizarGridVie()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaCelusNuevos();
        }*/
        public ABMCelusNuevos()
        {
            InitializeComponent();
        }

        private void ABMCelusNuevos_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = principal.DevolverListaCelusNuevos();
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusNuevos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CelularNuevo celuNuevo = new CelularNuevo(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text);
            principal.AltaCeluNuevo(celuNuevo);
            MessageBox.Show("Se ha agregado un producto del tipo Celular Nuevo");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusNuevos();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.BajaCeluNuevo((CelularNuevo)listBox1.SelectedItem);
            MessageBox.Show("Se ha borrado un producto del tipo Celular Nuevo");
            listBox1.DataSource = null;
            listBox1.DataSource = principal.DevolverListaCelusNuevos();
            listBox1.DisplayMember = "info_list_box";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CelularNuevo celuSeleccionado = (CelularNuevo)listBox1.SelectedItem;
            CelularNuevo modificacion = new CelularNuevo(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text);
            principal.ModificacionCeluNuevo(celuSeleccionado, modificacion);
            MessageBox.Show("Se ha modificado un producto del tipo Celular Nuevo");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusNuevos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABMProductos aBMProductos = new ABMProductos();
            aBMProductos.Show();
            this.Hide();
        }
    }
}
