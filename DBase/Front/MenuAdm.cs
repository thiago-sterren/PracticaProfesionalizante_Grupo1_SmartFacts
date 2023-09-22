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
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesionAdm isadm = new InicioSesionAdm();
            isadm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMProductos abmprod = new ABMProductos();
            abmprod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientesABM abmcli = new ClientesABM();
            abmcli.Show();
            this.Hide();
        }
    }
}
