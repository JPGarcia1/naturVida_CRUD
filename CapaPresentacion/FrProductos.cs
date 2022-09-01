using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class FrProductos : Form
    {
        CNNatur cNNatur = new CNNatur();
        public FrProductos()
        {
            InitializeComponent();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlIngresarPro.Visible = true;
            PnlConsultarPro.Visible = false;
            PnlModificarPro.Visible = false;
            PnlEliminarPro.Visible = false;
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlIngresarPro.Visible = false;
            PnlConsultarPro.Visible = true;
            PnlModificarPro.Visible = false;
            PnlEliminarPro.Visible = false;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlIngresarPro.Visible = false;
            PnlConsultarPro.Visible = false;
            PnlModificarPro.Visible = true;
            PnlEliminarPro.Visible = false;
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlIngresarPro.Visible = false;
            PnlConsultarPro.Visible = false;
            PnlModificarPro.Visible = false;
            PnlEliminarPro.Visible = true;
        }

        private void btnProSalir_Click(object sender, EventArgs e)
        {
            FrMenu frMenu = new FrMenu();
            this.Hide();
            frMenu.ShowDialog();
        }

        private void FrProductos_Load(object sender, EventArgs e)
        {
            CNNatur cNNatur = new CNNatur();

            txtConsultarPro.DataSource = cNNatur.listarPro();
            txtConsultarPro.DisplayMember = "proDescripcion";

            txtConsultModificarPro.DataSource = cNNatur.listarPro();
            txtConsultModificarPro.DisplayMember = "proCodigo";

            txtEliminarPro.DataSource = cNNatur.listarPro();
            txtEliminarPro.DisplayMember = "proDescripcion";
        }

        private void btnInProLimpiar_Click(object sender, EventArgs e)
        {
            txtInProCodigo.Value = 0;
            txtInProDescripcion.Text = string.Empty;
            txtInProValor.Text = string.Empty;
            txtInProCantidad.Text = string.Empty;
        }

        private void btnInProGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            CENatur cENatur = new CENatur();
            cENatur.ProCode = int.Parse(txtInProCodigo.Text);
            cENatur.ProDescrip = txtInProDescripcion.Text;
            cENatur.ProValue = double.Parse(txtInProValor.Text);
            cENatur.ProCant = int.Parse(txtInProCantidad.Text);

            resultado = cNNatur.validarProDatos(cENatur);
            if (resultado == false)
            {
                return;
            }
            else
            {
                cNNatur.insertPro(cENatur);
            }
        }

        private void btnConsultarPro_Click(object sender, EventArgs e)
        {
            CNNatur cNNatur = new CNNatur();
            txtConsultarPro.DataSource = cNNatur.listarPro();
            txtConsultarPro.DisplayMember = "cliNombre";
            GridConsultarPro.Rows.Clear();

            var Tabla = cNNatur.readPro();
            GridConsultarPro.DataSource = Tabla;
        }

        private void btnConsultModificarPro_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = cNNatur.searchPro(int.Parse(txtConsultModificarPro.Text));
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtModCodigo.Text = reader.GetString(0);
                    txtDescripModificarPro.Text = reader.GetString(1);
                    txtValModificarPro.Text = reader.GetString(2);
                    txtCantModificarPro.Text = reader.GetString(3);
                    var listar = new CNNatur();
                    txtConsultModificarPro.DataSource = listar.listarPro();
                    txtConsultModificarPro.DisplayMember = "proCodigo";
                }
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }
        private void btnSaveModificarPro_Click(object sender, EventArgs e)
        {
            CENatur cENatur = new CENatur();
            cENatur.ProCode = int.Parse(txtModCodigo.Text);
            cENatur.ProDescrip = txtDescripModificarPro.Text;
            cENatur.ProValue = double.Parse(txtValModificarPro.Text);
            cENatur.ProCant = int.Parse(txtCantModificarPro.Text);
            this.cNNatur.updatePro(cENatur);

            txtModCodigo.Text = string.Empty;
            txtDescripModificarPro.Text = string.Empty;
            txtValModificarPro.Text = string.Empty;
            txtCantModificarPro.Text = string.Empty;
        }

        private void btnEliminarPro_Click(object sender, EventArgs e)
        {
            CNNatur cNNatur = new CNNatur();

            CENatur cENatur = new CENatur();
            cENatur.ProDescrip = txtEliminarPro.Text;
            cNNatur.borrarPro(cENatur);

            txtEliminarPro.DataSource = cNNatur.listarPro();
            txtEliminarPro.DisplayMember = "proDescripcion";
        }
    }
}