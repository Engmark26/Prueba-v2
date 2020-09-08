using System;

namespace Helloworld
{

    class Program
    {
        static void Main(string[] args)
        {
            string Cadena;
            int DatoEntero;
            double DatoReal;
            Console.Write("¿Cual es tu nombre?: ");
            Cadena = Console.ReadLine();
            Console.Write("¿Cual es tu edad?: ");
            DatoEntero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el precio de unos cheetos: ");
            DatoReal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tu nombre: " + Cadena);
            Console.WriteLine("Tu edad: " + DatoEntero.ToString());
            Console.WriteLine("Barra pan: " + DatoReal.ToString("0.00"));

            Console.ReadKey();
        }

    }
}
