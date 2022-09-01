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

        public int ProCode { get => proCode; set => proCode = value; }
        public string ProDescrip { get => proDescrip; set => proDescrip = value; }
        public double ProValue { get => proValue; set => proValue = value; }
        public int ProCant { get => proCant; set => proCant = value; }
    }
}