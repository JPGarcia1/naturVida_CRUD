using System;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class CNNatur
    {
        CDNatur cDNatur = new CDNatur();
        public bool validarProDatos(CENatur producto)
        {
            bool resultado = true;
            if (producto.ProDescrip == String.Empty)
            {
                MessageBox.Show("La descripcion es obligatoria");
            }
            if (producto.ProValue < 0)
            {
                MessageBox.Show("El valor es obligatorio");
            }
            if (producto.ProCant < 0)
            {
                MessageBox.Show("La cantidad es obligatoria");
            }
            return resultado;
        }
        public void pruebaMySql()
        {
            cDNatur.pruebaConexion();
        }
        public void insertPro(CENatur insertPro)
        {
            cDNatur.insertProducto(insertPro);
        }
        public DataTable readPro()
        {
            return cDNatur.readProducto();
        }
        public DataTable listarPro()
        {
            return cDNatur.listarProducto();
        }
        public MySqlDataReader searchPro(int searchPro)
        {
            return cDNatur.buscarPro(searchPro);
        }
        public void updatePro(CENatur updatePro)
        {
            cDNatur.updateProducto(updatePro);
        }
        public void borrarPro(CENatur borrarPro)
        {
            cDNatur.deleteProducto(borrarPro);
        }
        public void insertCli(CENatur insertCli)
        {
            cDNatur.insertCliente(insertCli);
        }
        public DataTable readCli()
        {
            return cDNatur.readCliente();
        }
        public DataTable listarCli()
        {
            return cDNatur.ListarClientes();
        }
        public MySqlDataReader searchCli(int searchCli)
        {
            return cDNatur.buscarCliente(searchCli);
        }
        public void updateCli(CENatur updateCli)
        {
            cDNatur.updateCliente(updateCli);
        }
            public void deleteCli(CENatur deleteCli)
        {
            cDNatur.DeleteCliente(deleteCli);
        }
    }
}