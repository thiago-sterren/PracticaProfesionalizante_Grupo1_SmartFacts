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
        ApplicationDbContext context = new ApplicationDbContext();
        public ABMCelusUsados()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaCelusUsados();
        }

        private void ABMCelusUsados_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
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
                    CelularUsado celuUsado = new CelularUsado(textBox1.Text, textBox2.Text, double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text, textBox7.Text, textBox8.Text);
                    principal.AltaCeluUsado(celuUsado);
                    MessageBox.Show("Se ha agregado un producto del tipo Celular Usado");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
                CelularUsado idCelu = (CelularUsado)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
                principal.BajaCeluUsado(idCelu);
                MessageBox.Show("Se ha borrado un producto del tipo Celular Usado");
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
                    CelularUsado idCelu = (CelularUsado)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
                    if (celdaSeleccionada != null)
                    {
                        idCelu.marca_producto = textBox1.Text;
                        idCelu.nombre_producto = textBox2.Text;
                        idCelu.precio = double.Parse(textBox4.Text);
                        idCelu.almacenamiento = double.Parse(textBox5.Text);
                        idCelu.detalles = textBox6.Text;
                        idCelu.uso = textBox7.Text;
                        idCelu.condicion_bat = textBox8.Text;
                        principal.ModificacionCeluUsado(idCelu);
                        MessageBox.Show("Se ha modificado un producto del tipo Celular Usado");
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
            CelularUsado idCelu = (CelularUsado)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}