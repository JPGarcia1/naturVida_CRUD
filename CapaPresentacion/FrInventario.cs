using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrInventario : Form
    {
        CNNatur cNNatur = new CNNatur();
        public FrInventario()
        {
            InitializeComponent();
        }

        private void btnInSalir_Click(object sender, EventArgs e)
        {
            FrMenu frMenu = new FrMenu();
            this.Hide();
            frMenu.ShowDialog();
        }

        private void btnConsultarInventario_Click(object sender, EventArgs e)
        {
            GridInventario.Rows.Clear();

            var Tabla = cNNatur.readPro();
            GridInventario.DataSource = Tabla;
        }
    }
}
