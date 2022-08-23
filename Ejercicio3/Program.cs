using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funcion Factorial");
            Console.WriteLine("Escribe un numero para calcular su factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            int f = factorial(num);
            Console.WriteLine("El factorial del numero "+ num +" es: "+ f );
        }
        public static int factorial(int a)
        { 
            int contador = 1;
            int factor = 1;

            while(contador <= a)
            {               
                factor = factor * contador;
                contador = contador + 1;                
            }           

            return factor;
        }
    }
}
