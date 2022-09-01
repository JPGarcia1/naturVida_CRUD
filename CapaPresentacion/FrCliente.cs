using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class FrCliente : Form
    {
        CNNatur cNNatur = new CNNatur();
        public FrCliente()
        {
            InitializeComponent();
        }
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = true;
            pnlConsultar.Visible = false;
            pnlModificar.Visible = false;
            pnlEliminar.Visible = false;
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = false;
            pnlConsultar.Visible = true;
            pnlModificar.Visible = false;
            pnlEliminar.Visible = false;
        }

        private void editarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = false;
            pnlConsultar.Visible = false;
            pnlModificar.Visible = true;
            pnlEliminar.Visible = false;
        }

        private void eliminarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = false;
            pnlConsultar.Visible = false;
            pnlModificar.Visible = false;
            pnlEliminar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrMenu frMenu = new FrMenu();
            this.Hide();
            frMenu.ShowDialog();
        }

        private void FrCliente_Load(object sender, EventArgs e)
        {
            CNNatur cNNatur = new CNNatur();

            txtConsultarCli.DataSource = cNNatur.listarCli();
            txtConsultarCli.DisplayMember = "cliNombre";

            txtConsultarEditar.DataSource = cNNatur.listarCli();
            txtConsultarEditar.DisplayMember = "cliDocumento";

            txtEliminar.DataSource = cNNatur.listarCli();
            txtEliminar.DisplayMember = "cliNombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            CENatur cENatur = new CENatur();
            cENatur.CliNumber = int.Parse(txtNumero.Text);
            cENatur.CliName = txtNombre.Text;
            cENatur.CliDireccion = txtDireccion.Text;
            cENatur.CliTelefono = txtTelefono.Text;
            cENatur.CliCorreo = txtCorreo.Text;

            resultado = cNNatur.validarProDatos(cENatur);
            if (resultado == false)
            {
                return;
            }
            else
            {
                cNNatur.insertCli(cENatur);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }

        private void btnConsultarCli_Click(object sender, EventArgs e)
        {
            CNNatur cNNatur = new CNNatur();
            txtConsultarCli.DataSource = cNNatur.listarCli();
            txtConsultarCli.DisplayMember = "cliNombre";
            GridConsultar.Rows.Clear();

            var Tabla = cNNatur.readCli();
            GridConsultar.DataSource = Tabla;
        }

        private void btnConsultarEditar_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = cNNatur.searchCli(int.Parse(txtConsultarEditar.Text));
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtEditarNum.Text = reader.GetString(0);
                    txtEditarNombre.Text = reader.GetString(1);
                    txtEditarDireccion.Text = reader.GetString(2);
                    txtEditarTelefono.Text = reader.GetString(3);
                    txtEditarEmail.Text = reader.GetString(4);
                    var funciones = new CNNatur();
                    txtConsultarEditar.DataSource = funciones.listarCli();
                    txtConsultarEditar.DisplayMember = "clidocumento";
                }
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }

        private void txtGuardarEditar_Click(object sender, EventArgs e)
        {
            var cNNatur = new CNNatur();
            txtConsultarEditar.DataSource = cNNatur.listarCli();
            txtConsultarEditar.DisplayMember = "cliDocumento";

            CENatur cENatur = new CENatur();
            cENatur.CliNumber = int.Parse(txtEditarNum.Text);
            cENatur.CliName = txtEditarNombre.Text;
            cENatur.CliDireccion = txtEditarDireccion.Text;
            cENatur.CliTelefono = txtEditarTelefono.Text;
            cENatur.CliCorreo = txtEditarEmail.Text;
            this.cNNatur.updateCli(cENatur);

            txtEditarNum.Text = string.Empty;
            txtEditarNombre.Text = string.Empty;
            txtEditarDireccion.Text = string.Empty;
            txtEditarTelefono.Text = string.Empty;
            txtEditarEmail.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CNNatur cNNatur = new CNNatur();

            CENatur cENatur = new CENatur();
            cENatur.CliName = txtEliminar.Text;
            cNNatur.deleteCli(cENatur);

            txtEliminar.DataSource = cNNatur.listarCli();
            txtEliminar.DisplayMember = "cliNombre";
        }
    }
}
