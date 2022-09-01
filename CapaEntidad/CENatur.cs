using System;

namespace CapaEntidad
{
    public class CENatur
    {
        //Entidades de la tabla productos
        private int proCode;
        private string proDescrip;
        private double proValue;
        private int proCant;

        private int cliNumber;
        private string cliName;
        private string cliDireccion;
        private string cliTelefono;
        private string cliCorreo;

        public int ProCode { get => proCode; set => proCode = value; }
        public string ProDescrip { get => proDescrip; set => proDescrip = value; }
        public double ProValue { get => proValue; set => proValue = value; }
        public int ProCant { get => proCant; set => proCant = value; }
        public int CliNumber { get => cliNumber; set => cliNumber = value; }
        public string CliName { get => cliName; set => cliName = value; }
        public string CliDireccion { get => cliDireccion; set => cliDireccion = value; }
        public string CliTelefono { get => cliTelefono; set => cliTelefono = value; }
        public string CliCorreo { get => cliCorreo; set => cliCorreo = value; }
    }
}