using System;

namespace TPOO1_Ej3
{
    class Tester
    {
        static void Main(string[] args)
        {
            int legajo, cantH;
            double valorH;
            string respuesta;
            Console.WriteLine("B)Escriba nro. de legajo: ");
            respuesta = Console.ReadLine();
            legajo = Convert.ToInt32(respuesta);
            Console.WriteLine("B)Escriba cantidad de horas trabajadas: ");
            respuesta = Console.ReadLine();
            cantH = Convert.ToInt32(respuesta);
            Console.WriteLine("B)Escriba valor por hora trabajada: ");
            respuesta = Console.ReadLine();
            valorH = Convert.ToDouble(respuesta);
            Empleado empleado_ = new Empleado(legajo, cantH, valorH);
            Console.WriteLine("Nro. Legajo: " + legajo.ToString() + " |Sueldo empleado " + empleado_.GetSueldo().ToString());
            Console.WriteLine();




            Console.WriteLine("C)Escriba nro. de legajo: ");
            respuesta = Console.ReadLine();
            Empleado empleado2_ = new Empleado(Convert.ToInt32(respuesta));

            Console.WriteLine("C)Escriba cantidad de horas trabajadas: ");
            respuesta = Console.ReadLine();
            empleado2_.SetCantHoras(Convert.ToInt32(respuesta));

            Console.WriteLine("C)Escriba valor por hora trabajada: ");
            respuesta = Console.ReadLine();
            empleado2_.SetValorHoras(Convert.ToDouble(respuesta));
            Console.WriteLine("Nro. Legajo: " + empleado2_.GetLegajo().ToString() + " |Sueldo empleado " + empleado2_.GetSueldo().ToString());

            Console.ReadLine();
        }
    }
}
