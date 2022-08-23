using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elije una opcion");
            Console.WriteLine("1.Decimal a Binario");
            Console.WriteLine("2.Binario a Decimal");            

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Digite un numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Decimal(num);
                    break;
                case 2:
                    Console.WriteLine("Digite un numero");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Binario(num2);
                    break;
            }       
        }
        public static void Decimal(int a)
        {
            
            double x = 1;
            double binario = 0;
            Console.WriteLine("El numero " + a + " convertido a binario es: ");
            while (a >= 1)
            {

                if (a % 2 == 1)
                {

                    binario = binario + x;
                }
                a = Math.Abs(a / 2);
                x = x * 10;

            }
            Console.WriteLine(binario);

        }
        public static void Binario(int a)
        {
           
            string binario = Convert.ToString(a);
            int n = binario.Length;
            int x = 0;
            Console.WriteLine("El numero " + a + " convertido a Decimal es: ");
            double deci = 0;
            while (n > 0)
            {                
                if (binario.Substring(n) == "1")
                {
                    deci = deci + (Math.Pow(2,x));
                }
                n = n - 1;
                x = x + 1;           
            }
            Console.WriteLine(deci);

        }
    }
}
