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
    public partial class Login : Form
    {
        CNNatur cNNatur = new CNNatur();

        string usuario = "";
        string contrase�a = "";
        public Login()
        {
            InitializeComponent();
        }
        private void bntIngresar_Click(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text == usuario && txtLoginContrase�a.Text == contrase�a)
            {
                FrMenu menu = new FrMenu();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrecto");
            }
        }

        private void btnLogSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogConexion_Click(object sender, EventArgs e)
        {
            cNNatur.pruebaMySql();
            MessageBox.Show("Conexion exitosa con la base de datos naturVida");
        }
    }
}