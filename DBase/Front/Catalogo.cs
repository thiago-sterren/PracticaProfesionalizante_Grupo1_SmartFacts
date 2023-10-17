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
            CatalogoCeluNuevos ccn = new CatalogoCeluNuevos();
            ccn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoCeluaresUsados ccu = new CatalogoCeluaresUsados();
            ccu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CatalogoNotebooks cn = new CatalogoNotebooks();
            cn.Show();
            this.Hide();
        }
    }
}
