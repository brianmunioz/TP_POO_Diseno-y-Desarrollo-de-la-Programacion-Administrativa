using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOO_1_EJ1
{
    class TPOO_1_EJ1
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese el punto 1:");
            string pto1 = Console.ReadLine();
            Console.WriteLine("Ingrese el punto 2:");
            string pto2 = Console.ReadLine();


            punto obj = new punto(Convert.ToInt32(pto1), Convert.ToInt32(pto2));




            if (obj.igualA(Convert.ToInt32(pto2)))
            {
                Console.WriteLine("Los puntos son iguales");
            }
            else
            {
                Console.WriteLine("Los puntos son diferentes");

            }


            Console.WriteLine();


            obj.setX(obj.mas(obj.getY(), obj.getX()));
            Console.WriteLine("Sumado x= pto1+pto2: "+obj.toString());

            obj.setX(obj.menos(obj.getY(), obj.getX()));
            Console.WriteLine("Restado x= pto2-pto1: " + obj.toString());

            Console.ReadLine();
        }
    }
}
