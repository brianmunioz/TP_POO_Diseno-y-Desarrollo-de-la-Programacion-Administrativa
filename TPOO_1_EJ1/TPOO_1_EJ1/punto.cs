using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOO_1_EJ1
{
    class punto
    {
        
        
        #region Atributos de instancia
        private int _x;
        private int _y;
        #endregion
        #region Constructores
        public  punto(int valX, int valY) {
            setX(valX);
            setY(valY);                
              }

    #endregion
        #region Consultas
    public int getX()
    {
            return _x;
    }
    public int getY()
    {
            return _y;
    }
 
        public bool igualA(int otroNumero)
        {           
            if(_x==otroNumero)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public String toString()
        {
            return "X: "+ _x + "  Y: " + _y;
        }
        #endregion
        #region Comandos
        public int setX(int numero)
        {
            _x = numero;
            return _x;
        }
        public int setY(int numero)
        {
            _y = numero;
            return _y;
        }
        public int menos(int otroPunto, int punto)
        {
            return otroPunto - punto;
        }
        public int mas(int otroPunto, int punto)
        {
            return otroPunto + punto;
        }
        #endregion
        
    }
}
