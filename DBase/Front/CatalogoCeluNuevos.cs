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
    public partial class CatalogoCeluNuevos : Form
    {
        Principal principal = new Principal();
        public CatalogoCeluNuevos()
        {
            InitializeComponent();
        }

        private void CatalogoCeluNuevos_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaCelusNuevos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Pedido pedido = new Pedido();
            pedido.fecha_pedido = DateTime.Now;
            pedido.*/
        }
    }
}
