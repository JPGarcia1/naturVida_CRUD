using System;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Windows.Forms;
using System.Data;

namespace CapaDatos
{
    public class CDNatur
    {
        string cadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;database=naturvida";

        public void pruebaConexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos"+ ex.Message);
                return;
            }
        }
        public void insertProducto(CENatur cEInsertProducto)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `naturvida`.`productos` (`proDescripcion`, `proValor`, `proCantidad`) VALUES ('"+cEInsertProducto.ProDescrip+"', '"+cEInsertProducto.ProValue+"', '"+cEInsertProducto.ProCant+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Producto registrado exitosamente");
        }
        public DataTable readProducto()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            DataTable ds = new DataTable();
            mySqlConnection.Open();
            string query = "SELECT * FROM `productos` LIMIT 1000;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, mySqlConnection);
            adaptador.Fill(ds);
            return ds;
        }
            public DataTable listarProducto()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            DataTable ds = new DataTable();
            mySqlConnection.Open();
            string query = "SELECT `proCodigo`, `proDescripcion` FROM `productos` limit 1000;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, mySqlConnection);
            adaptador.Fill(ds);
            return ds;
        }
        public void deleteProducto(CENatur cEDeleteProducto)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string query = "DELETE FROM `productos` WHERE (`proDescripcion` = '"+cEDeleteProducto.ProDescrip+"'); ";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Eliminado");
        }
    }
}