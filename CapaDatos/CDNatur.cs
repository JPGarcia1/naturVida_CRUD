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
                MessageBox.Show("Error al conectar con la base de datos" + ex.Message);
                return;
            }
        }
        public void insertProducto(CENatur cEInsertProducto)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `naturvida`.`productos` (`proDescripcion`, `proValor`, `proCantidad`) VALUES ('" + cEInsertProducto.ProDescrip + "', '" + cEInsertProducto.ProValue + "', '" + cEInsertProducto.ProCant + "');";
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
        public MySqlDataReader buscarPro(int cENatur)
        {
            string cadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;database=naturvida";
            MySqlDataReader reader = null;
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string query = "Select * from productos where (proCodigo = "+cENatur+");";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            reader = mySqlCommand.ExecuteReader();
            return reader;
            mySqlConnection.Close();
            MessageBox.Show("Registro Encontrado");
        }
        public void updateProducto(CENatur cENatur)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            try
            {
                mySqlConnection.Open();
                string Query = "UPDATE `productos` SET `proDescripcion` = '"+cENatur.ProDescrip+"', `proValor` = '"+cENatur.ProValue+"', `proCantidad` = '"+cENatur.ProCant+"' WHERE (`proDescripcion` = '"+cENatur.ProCode+"');";
                MySqlCommand cmd = new MySqlCommand(Query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Actualizacion exitosa");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }

            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }
        public void deleteProducto(CENatur cEDeleteProducto)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string query = "DELETE FROM `productos` WHERE (`proDescripcion` = '" + cEDeleteProducto.ProDescrip + "'); ";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Eliminado");
        }
        public void insertCliente(CENatur cENatur)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `clientes` (`clidocumento`, `clinombre`, `clidireccion`, `clitelefono`, `clicorreo`) VALUES ('"+cENatur.CliNumber+ "', '"+cENatur.CliName+"', '"+cENatur.CliDireccion+"', '"+cENatur.CliTelefono+"', '"+cENatur.CliCorreo+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro exitoso");
        }
        public DataTable readCliente()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            DataTable ds = new DataTable();
            mySqlConnection.Open();
            string query = "SELECT * FROM `clientes` LIMIT 1000;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, mySqlConnection);
            adaptador.Fill(ds);
            return ds;
        }
        public DataTable ListarClientes()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            DataTable ds = new DataTable();
            mySqlConnection.Open();
            string query = "SELECT `cliDocumento`, `cliNombre` FROM `clientes` LIMIT 1000;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, mySqlConnection);
            adaptador.Fill(ds);
            return ds;
        }
        public MySqlDataReader buscarCliente(int cENatur)
        {
            string cadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;database=naturvida";
            MySqlDataReader reader = null;
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string query = "SELECT * FROM clientes WHERE (clidocumento = " +cENatur+";";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            reader = mySqlCommand.ExecuteReader();
            return reader;
            mySqlConnection.Close();
            MessageBox.Show("Registro Encontrado");
        }
        public void updateCliente(CENatur cENatur)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            try
            {
                mySqlConnection.Open();
                string Query = "UPDATE `clientes` SET `clinombre` = '"+cENatur.CliName+"', `clidireccion` = '"+cENatur.CliDireccion+"', `clitelefono` = '"+cENatur.CliTelefono+"', `clicorreo` = '"+cENatur.CliCorreo+"' WHERE (`clidocumento` = '"+cENatur.CliNumber+"');";
                MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Actualizacion exitosa");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
                throw;
            }

            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        public void DeleteCliente(CENatur cENatur)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string query = "DELETE FROM `clientes` WHERE (`cliNombre` = '"+cENatur.CliName+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Eliminado");
        }
    }
}