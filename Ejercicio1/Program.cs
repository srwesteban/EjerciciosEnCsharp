using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();
            saludar(nombre);
        }
        public static void saludar(string a) => Console.WriteLine("Hola "+a);
    }
}
