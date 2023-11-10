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
    public partial class ABMCelusNuevos : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public ABMCelusNuevos()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaCelusNuevos();
        }

        private void ABMCelusNuevos_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                string txtPrecio = textBox4.Text;
                double numeroPrecio;
                string txtAlmacenamiento = textBox5.Text;
                double numeroAlmacenamiento;
                if (double.TryParse(txtPrecio, out numeroPrecio) && double.TryParse(txtAlmacenamiento, out numeroAlmacenamiento))
                {
                    CelularNuevo celuNuevo = new CelularNuevo(textBox1.Text, textBox2.Text, double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text);
                    principal.AltaCeluNuevo(celuNuevo);
                    MessageBox.Show("Se ha agregado un producto del tipo Celular Nuevo");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
                CelularNuevo idCelu = (CelularNuevo)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
                principal.BajaCeluNuevo(idCelu);
                MessageBox.Show("Se ha borrado un producto del tipo Celular Nuevo");
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Seleccione una celda, por favor");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                string txtPrecio = textBox4.Text;
                double numeroPrecio;
                string txtAlmacenamiento = textBox5.Text;
                double numeroAlmacenamiento;
                if (double.TryParse(txtPrecio, out numeroPrecio) && double.TryParse(txtAlmacenamiento, out numeroAlmacenamiento))
                {
                    int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
                    CelularNuevo idCelu = (CelularNuevo)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
                    if (celdaSeleccionada != null)
                    {
                        idCelu.marca_producto = textBox1.Text;
                        idCelu.nombre_producto = textBox2.Text;
                        idCelu.precio = double.Parse(textBox4.Text);
                        idCelu.almacenamiento = double.Parse(textBox5.Text);
                        idCelu.garantia = textBox6.Text;
                        principal.ModificacionCeluNuevo(idCelu);
                        MessageBox.Show("Se ha modificado un producto del tipo Celular Nuevo");
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
            CelularNuevo idCelu = (CelularNuevo)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
            if (txtModStock.Text == "" || celdaSeleccionada == null || int.Parse(txtModStock.Text) < 0)
            {
                MessageBox.Show("Por favor, seleccione un producto e ingrese un valor mayor o igual a cero");
            }
            else
            {
                principal.ModStock(idCelu, int.Parse(txtModStock.Text));
                context.SaveChanges();
                MessageBox.Show("Cambio realizado");
                ActualizarDataGrid();
            }
        }
    }
}
