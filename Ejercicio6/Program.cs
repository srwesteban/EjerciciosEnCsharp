using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funcion mostrar array");

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            array(num);
        }
        public static void array(int[]a)
        {
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
