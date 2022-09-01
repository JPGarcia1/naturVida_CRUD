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
            txtConsultarPro.DisplayMember = "proDescripcion";
            GridConsultarPro.Rows.Clear();

            var Tabla = this.cNNatur.readPro();
            var Filas = Tabla.Rows.Count;
            if (Filas > 0)
            {
                for (int i = 0; i < Filas; i++)
                {
                    String Codigo = Tabla.Rows[i][0].ToString();
                    String Descipcion = Tabla.Rows[i][1].ToString();
                    String Valor = Tabla.Rows[i][2].ToString();

                    GridConsultarPro.Rows.Add(Codigo, Descipcion, Valor);
                }
            }
        }
        private void btnEliminarPro_Click(object sender, EventArgs e)
        {
            CNNatur cNNatur = new CNNatur();
            if (txtEliminarPro.Text == "0") return;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CENatur cENatur = new CENatur();
                cENatur.ProDescrip = txtEliminarPro.Text;
                cNNatur.borrarPro(cENatur);

                txtEliminarPro.DataSource = cNNatur.listarPro();
                txtEliminarPro.DisplayMember = "proDescripcion";
            }
            txtEliminarPro.DataSource = cNNatur.listarPro();
            txtEliminarPro.DisplayMember = "proDescripcion";
        }
    }
}