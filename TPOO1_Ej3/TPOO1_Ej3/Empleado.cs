using System;
using System.Collections.Generic;
using System.Text;

namespace TPOO1_Ej3
{
    class Empleado
    {
        #region Atributos
        private int legajo;
        private int cantHoras;
        private double valorHoras;
        #endregion
        #region Constructor
        public Empleado(int leg)
        {
            legajo = leg;
        }
        public Empleado(int leg,int horas, double valor)
        {
            legajo = leg;
            cantHoras = horas;
            valorHoras = valor;
        }
        #endregion
        #region Comandos
       public double SetValorHoras(double valorH)
        {
            valorHoras = valorH;
            return valorHoras;
        }
       public int SetCantHoras(int cantH)
        {
            cantHoras = cantH;
            return cantHoras;
        }
        #endregion
        #region Consultas 
        public int GetLegajo()
        {
            return legajo;
        }
        public int GetCantH()
        {
            return cantHoras;
        }
        public double GetValorH()
        {
            return valorHoras;
        }
        public double GetSueldo()
        {
            return valorHoras * cantHoras;
        }
        #endregion

    }
}
