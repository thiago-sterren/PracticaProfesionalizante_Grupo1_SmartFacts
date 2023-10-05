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
    public partial class ABMCelusUsados : Form
    {
        Principal principal = new Principal();
        public ABMCelusUsados()
        {
            InitializeComponent();
        }

        private void ABMCelusUsados_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusUsados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CelularUsado celuUsado = new CelularUsado(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text, textBox7.Text, textBox8.Text);
            principal.AltaCeluUsado(celuUsado);
            MessageBox.Show("Se ha agregado un producto del tipo Celular Usado");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusUsados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.BajaCeluUsado((CelularUsado)listBox1.SelectedItem);
            MessageBox.Show("Se ha borrado un producto del tipo Celular Usado");
            listBox1.DataSource = null;
            listBox1.DataSource = principal.DevolverListaCelusUsados();
            listBox1.DisplayMember = "info_list_box";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CelularUsado celuSeleccionado = (CelularUsado)listBox1.SelectedItem;
            CelularUsado modificacion = new CelularUsado(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text, textBox7.Text, textBox8.Text);
            principal.ModificacionCeluUsado(celuSeleccionado, modificacion);
            MessageBox.Show("Se ha modificado un producto del tipo Celular Usado");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusUsados();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABMProductos aBMProductos = new ABMProductos();
            aBMProductos.Show();
            this.Hide();
        }
    }
}
