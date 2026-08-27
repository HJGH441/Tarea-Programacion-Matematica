using System;


namespace Metodo_de_la_secante
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x = 0.9;
            double x1 = 1.1;
            double tolerancia = 0.001;
            int maximo_iteraciones = 20;

            for (int i = 1; i <= maximo_iteraciones; i++)
            {
                double x2 = x1 - Funcion.funcion(x1) * (x1 - x) / (Funcion.funcion(x1) - Funcion.funcion(x));
                double error = Math.Abs(x2 - x1);
                if (error < tolerancia)
                {
                    Console.WriteLine("Tu x2 Final es = " + x2);
                    break;
                }

                x = x1;
                x1 = x2;
                Console.WriteLine("Numero de iteracion : " + i);
                Console.WriteLine("X es igual a : " + x);
                Console.WriteLine("X1 es igual a : " + x1);
                Console.WriteLine("X2 es igual a : " + x2);
                Console.WriteLine("error es igual a : " + error);
            }
        }
    }
}