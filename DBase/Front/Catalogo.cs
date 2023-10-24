using Backk;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
        Pedido pedido = new Pedido();
        public Catalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusNuevos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusUsados();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaNotebooks();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            pedido.productos = new List<PedidoProducto>();
            pedido.fecha_pedido = DateTime.Now;
            pedido.id_cliente_pedido = ClienteActual.cliente_actual;
            pedido.cantidad_productos = pedido.productos.Count();
            //principal.AgregarPedido(pedido);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                PedidoProducto pp = new PedidoProducto();
                pp.id_producto = (Producto)listBox1.SelectedItem;
                bool resultado = principal.AgregarProducto(pedido, pp);
                if (resultado == true)
                {
                    MessageBox.Show("El producto ha sido agregado a su carrito");
                    pedido.cantidad_productos = pedido.productos.Count();
                }
                else
                {
                    MessageBox.Show("Este producto está fuera de stock");
                }
                listBox1.DataSource = null;
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
            List<string> pedido_completo = new List<string>();
            foreach (PedidoProducto pp in pedido.productos)
            {
                Producto producto = pp.id_producto;
                pedido_completo.Add(producto.nombre_producto);
            }
            string mensaje = pedido_completo.ToString();
            MessageBox.Show(mensaje);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
