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
    public partial class CatalogoNotebooks : Form
    {
        Principal principal = new Principal();
        public CatalogoNotebooks()
        {
            InitializeComponent();
        }

        private void CatalogoNotebooks_Load(object sender, EventArgs e)
        {
            principal.DevolverListaNotebooks();
        }

        private void btnAddCarrito_Click(object sender, EventArgs e)
        {
            
        }
    }
}
