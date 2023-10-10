﻿using Backk;
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
    public partial class ABMNotebooks : Form
    {
        Principal principal = new Principal();
        public ABMNotebooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notebook noteNueva = new Notebook(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text, double.Parse(textBox7.Text), double.Parse(textBox8.Text));
            principal.AltaNotebook(noteNueva);
            MessageBox.Show("Se ha agregado un producto del tipo Notebook");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaNotebooks();
        }

        private void ABMNotebooks_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaNotebooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.BajaNotebook((Notebook)listBox1.SelectedItem);
            MessageBox.Show("Se ha borrado un producto del tipo Notebook");
            listBox1.DataSource = null;
            listBox1.DataSource = principal.DevolverListaNotebooks();
            listBox1.DisplayMember = "info_list_box";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Notebook noteSeleccionada = (Notebook)listBox1.SelectedItem;
            Notebook modificacion = new Notebook(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text, double.Parse(textBox7.Text), double.Parse(textBox8.Text));
            principal.ModificacionNotebook(noteSeleccionada, modificacion);
            MessageBox.Show("Se ha modificado un producto del tipo Notebook");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaNotebooks();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABMProductos aBMProductos = new ABMProductos();
            aBMProductos.Show();
            this.Hide();
        }
    }
}