using Backk;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        ApplicationDbContext context = new ApplicationDbContext();
        public ABMNotebooks()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaNotebooks();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                string txtPrecio = textBox4.Text;
                double numeroPrecio;
                string txtAlmacenamiento = textBox5.Text;
                double numeroAlmacenamiento;
                if (double.TryParse(txtPrecio, out numeroPrecio) && double.TryParse(txtAlmacenamiento, out numeroAlmacenamiento))
                {
                    Notebook noteNueva = new Notebook(textBox1.Text, textBox2.Text, double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text, double.Parse(textBox7.Text), double.Parse(textBox8.Text));
                    principal.AltaNotebook(noteNueva);
                    MessageBox.Show("Se ha agregado un producto del tipo Notebook");
                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Los datos de la casilla de precio o almacenamiento fueron ingresados en un formato que no corresponde, inténtelo de nuevo");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos, por favor");
            }
        }

        private void ABMNotebooks_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
                Notebook idNotebook = (Notebook)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
                principal.BajaNotebook(idNotebook);
                MessageBox.Show("Se ha borrado un producto del tipo Notebook");
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Seleccione una celda, por favor");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                string txtPrecio = textBox4.Text;
                double numeroPrecio;
                string txtAlmacenamiento = textBox5.Text;
                double numeroAlmacenamiento;
                if (double.TryParse(txtPrecio, out numeroPrecio) && double.TryParse(txtAlmacenamiento, out numeroAlmacenamiento))
                {
                    int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
                    Notebook idNotebook = (Notebook)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
                    if (celdaSeleccionada != null)
                    {
                        idNotebook.marca_producto = textBox1.Text;
                        idNotebook.nombre_producto = textBox2.Text;
                        idNotebook.precio = double.Parse(textBox4.Text);
                        idNotebook.almacenamiento = double.Parse(textBox5.Text);
                        idNotebook.idioma_teclado = textBox6.Text;
                        idNotebook.cm_alto = double.Parse(textBox7.Text);
                        idNotebook.cm_ancho = double.Parse(textBox8.Text);
                        principal.ModNote(idNotebook);
                        MessageBox.Show("Se ha modificado un producto del tipo Notebook");
                        ActualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una celda, por favor");
                    }
                }
                else
                {
                    MessageBox.Show("Los datos de la casilla de precio o almacenamiento fueron ingresados en un formato que no corresponde, inténtelo de nuevo");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos, por favor");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABMProductos aBMProductos = new ABMProductos();
            aBMProductos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
            Notebook idNotebook = (Notebook)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
            if (txtModStock.Text == "" || celdaSeleccionada == null || int.Parse(txtModStock.Text) < 0)
            {
                MessageBox.Show("Por favor, seleccione un producto e ingrese un valor mayor o igual a cero");
            }
            else
            {
                principal.ModStock(idNotebook, int.Parse(txtModStock.Text));
                context.SaveChanges();
                MessageBox.Show("Cambio realizado");
                ActualizarDataGrid();
            }
        }
    }
}
