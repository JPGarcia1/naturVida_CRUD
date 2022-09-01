using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrFacturacion : Form
    {
        public FrFacturacion()
        {
            InitializeComponent();
        }

        private void btnFacSalir_Click(object sender, EventArgs e)
        {
            FrMenu frMenu = new FrMenu();
            this.Hide();
            frMenu.ShowDialog();
        }
    }
}
