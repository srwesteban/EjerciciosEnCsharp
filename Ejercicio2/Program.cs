using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funcion Suma\n");
            Console.WriteLine("Escribe un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro numero");
            int num2 = Convert.ToInt32(Console.ReadLine());     
            int resultado= sumar(num, num2);
            Console.WriteLine("La Suma de: " + num + " + " + num2 + " es: " + resultado); 
        }
        public static int sumar(int a, int b) => a + b;
    }
}
