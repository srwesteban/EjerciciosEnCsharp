using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funcion fibbonacci\n");
            Console.WriteLine("Ingresa un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Serie: ");
            Fibonacci(num);  
            
        }
        public static void Fibonacci(int f)
        {
            int a = 0;
            int b = 1;
            for (int i = 1; i <= f; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(a +",");
                    a = a + b;
                }
                else
                {
                    Console.Write(b+",");
                    b = b + a;
                }
            }
            Console.WriteLine();
        }
    }
}
