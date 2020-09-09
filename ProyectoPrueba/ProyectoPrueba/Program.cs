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
            Console.Write("¿Como te llamas?: ");
            Cadena = Console.ReadLine();
            Console.Write("¿Cuantos años tienes?: ");
            DatoEntero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el precio del pan: ");
            DatoReal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tu nombre: " + Cadena);
            Console.WriteLine("Tu edad: " + DatoEntero.ToString());
            Console.WriteLine("Barra pan: " + DatoReal.ToString("0.00"));

            Console.ReadKey();
        }

    }
}
