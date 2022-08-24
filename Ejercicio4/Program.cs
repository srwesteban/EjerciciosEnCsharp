using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funcion Convertir\n");
            Console.WriteLine("Elije una opcion");
            Console.WriteLine("1.Decimal a Binario");
            Console.WriteLine("2.Binario a Decimal");            

            int opcion = Convert.ToInt32(Console.ReadLine());

            opc(opcion);
        }
        public static void opc(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Digite un numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Decimal(num);
                    break;
                case 2:
                    Console.WriteLine("Digite un numero");
                    long num2 = Convert.ToInt64(Console.ReadLine());                    
                    long g = Binario(num2);
                    Console.WriteLine(g);
                    break;
            }
        }

        public static void Decimal(int a)
        {            
            double x = 1;
            double binario = 0;
            Console.WriteLine("El numero " + a + " convertido a Binario es: ");
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
        public static int Binario(long a)
        {        
            int n =0;
            int x = 0;
            const int div = 10;
            Console.WriteLine("El numero " + a + " convertido a Decimal es: ");

            for(long i = a, j = 0; i > 0; i/= div,j++)
            {
                x = (int)i % div;
                if(x!= 1 && x != 0)
                {
                    Console.WriteLine("No se puede convertir");
                }
                n += x * (int)Math.Pow(2, j);
            }
            return n;        
        }
    }
}
