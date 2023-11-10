using Backk;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Identity.Client.Extensibility;
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
    public partial class Catalogo : Form
    {
        Principal principal = new Principal();
        List<Producto> lista = new List<Producto>();
        ApplicationDbContext context = new ApplicationDbContext();
        public Catalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea regresar al menú principal? Su pedido será cancelado", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                principal.DevolucionProductos(lista);
                MessageBox.Show("Pedido cancelado");
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverCNCatalogo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverCUCatalogo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverNoteCatalogo();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int celdaSeleccionada = dataGridView1.CurrentCellAddress.Y;
            Producto? idProducto = (Producto)dataGridView1.Rows[celdaSeleccionada].DataBoundItem;
            if (celdaSeleccionada != null)
            {
                bool resultado = principal.AgregarProducto(lista, idProducto);
                if (resultado == true)
                {
                    MessageBox.Show("El producto ha sido agregado a su carrito");
                }
                else
                {
                    MessageBox.Show("Este producto está fuera de stock");
                }
                dataGridView1.DataSource = null;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
            {
                string pedido_completo = "";
                double precio_total = 0;
                foreach (Producto p in lista)
                {
                    pedido_completo += $" - {p.nombre_producto}";
                    precio_total += p.precio;
                }
                MessageBox.Show($"Su carrito contiene: {pedido_completo}. El total a pagar es de: ${precio_total}");
                DialogResult resultado = MessageBox.Show("¿Desea efectuar la compra?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Pedido pedido = new Pedido();
                    pedido.fecha_pedido = DateTime.Now;
                    pedido.productos = lista;
                    pedido.cantidad_productos = pedido.productos.Count();
                    pedido.id_cliente = ClienteActual.cliente_actual;
                    principal.AltaPedido(pedido);
                    MessageBox.Show("¡Muchas gracias por su compra! Diríjase a la caja para acordar el método de pago con nuestro cajero y así recibir su pedido");
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                else if (resultado == DialogResult.No)
                {
                    principal.DevolucionProductos(lista);
                    MessageBox.Show("Pedido cancelado");
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No puede realizar un pedido si no ha agregado productos al carrito");
            }
        }
        private void button7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
