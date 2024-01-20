using System;

namespace TPOO1_Ej2
{
    class TPOO1_Ej2
    {
        static void Main(string[] args)
        {

            fecha f1 = new fecha(20,12,1997);
            fecha unaFecha = new fecha(19, 12, 1997);
            fecha otraFecha = new fecha(21, 12, 1997);

            Console.WriteLine("-Igualdad");
            if (f1.igualA(otraFecha.getFecha()))
            {
                Console.WriteLine("Respuesta: SI");
            }
            else
            {
                Console.WriteLine("Respuesta: NO");

            }
            Console.WriteLine("-Menor");
            if (f1.menorQue(otraFecha.getFecha()))
            {
                Console.WriteLine("Respuesta: SI");
            }
            else
            {
                Console.WriteLine("Respuesta: NO");

            }

            Console.WriteLine("-Mayor");
            if (f1.mayorQue(otraFecha.getFecha()))
            {
                Console.WriteLine("Respuesta: SI");
            }
            else
            {
                Console.WriteLine("Respuesta: NO");

            }


            Console.WriteLine("¿Se encuentra entre la fecha "+ Convert.ToDateTime(unaFecha.getFecha()).ToString("dd/MM/yyyy")+" y "+
               Convert.ToDateTime(otraFecha.getFecha()).ToString("dd/MM/yyyy") + "?" );

            if (  f1.seEncuentraEntre(unaFecha.getFecha(),otraFecha.getFecha()))
            {
                Console.WriteLine("Respuesta: SI");
            }
            else
            {
                Console.WriteLine("Respuesta: NO");

            }

            Console.ReadLine();
        }
    }
}
