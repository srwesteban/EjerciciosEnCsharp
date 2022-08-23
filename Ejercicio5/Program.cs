using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa cuantos numeros deseas generar");
            int num = Convert.ToInt32(Console.ReadLine());            
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
                    Console.WriteLine(a);
                    a = a + b;
                }
                else
                {
                    Console.WriteLine(b);
                    b = b + a;
                }
            }
        }
    }
}
