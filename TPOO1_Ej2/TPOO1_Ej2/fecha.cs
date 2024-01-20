using System;
using System.Collections.Generic;
using System.Text;

namespace TPOO1_Ej2
{
    class fecha
    {
        #region Atributos
        private int dia;
        private int mes;
        private int año;

        #endregion
        #region constructores 
        public fecha(int _dia, int _mes, int _año)
        {
            dia = _dia;
            mes = _mes;
            año = _año;
        }
        #endregion
        #region consultas
        public string getFecha()
        {
            return  dia.ToString() + "-" + mes.ToString() + "-" + año.ToString(); ;
        }
        public int getDia()
        {
            return dia;
        }
        public int getMes()
        {
            return mes;
        }
        public int getAño()
        {
            return año;
        }
        public bool igualA(string otraFecha)
        {
            if (getFecha() == otraFecha)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool mayorQue(string otraFecha)
        {
            DateTime fecha1 = Convert.ToDateTime(getFecha());
            DateTime fecha2 = Convert.ToDateTime(otraFecha);
            if (fecha1 > fecha2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool mayorIgualQue(string otraFecha)
        {
            DateTime fecha1 = Convert.ToDateTime(getFecha());
            DateTime fecha2 = Convert.ToDateTime(otraFecha);
            if (fecha1 >= fecha2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool menorQue(string otraFecha)
        {
            DateTime fecha1 = Convert.ToDateTime(getFecha());
            DateTime fecha2 = Convert.ToDateTime(otraFecha);
            if (fecha1 < fecha2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool menorIgualQue(string otraFecha)
        {
            DateTime fecha1 = Convert.ToDateTime(getFecha());
            DateTime fecha2 = Convert.ToDateTime(otraFecha);
            if (fecha1 <= fecha2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool seEncuentraEntre(string unaFecha, string otraFecha)
        {
            DateTime fechaDelObjeto = Convert.ToDateTime(getFecha());
            DateTime fecha1 = Convert.ToDateTime(unaFecha);
            DateTime fecha2 = Convert.ToDateTime(otraFecha);

            if ((fechaDelObjeto > fecha1) && (fechaDelObjeto <= fecha2))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        #endregion
        #region Comandos
        public int setDia(int unNumero)
        {
            dia = unNumero;
            return dia;
        }
        public int setMes(int unNumero)
        {
            mes = unNumero;
            return mes;
        }
        public int setAño(int unNumero)
        {
            año = unNumero;
            return año;
        }
        #endregion
    }
}
