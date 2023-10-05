using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backk;

namespace Front
{
    public partial class ABMProductos : Form
    {
        Principal principal = new Principal();
        ApplicationDbContext context = new ApplicationDbContext();
        public ABMProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdm menuadm = new MenuAdm();
            menuadm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMCelusNuevos aBMCelusNuevos = new ABMCelusNuevos();
            aBMCelusNuevos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMCelusUsados aBMCelusUsados = new ABMCelusUsados();
            aBMCelusUsados.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABMNotebooks aBMNotebooks = new ABMNotebooks();
            aBMNotebooks.Show();
            this.Hide();
        }
    }
}
